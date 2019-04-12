#include <SPI.h>
#include <MFRC522.h>
#include <EEPROM.h>
#include <Servo.h>

#define RESETPIN 9
#define SDAPIN 10
#define GLIGHT 6
#define RLIGHT 7


byte readCard[4];
byte counter;
bool result=false;
int successRead;
int buzzerPin = 5;
float C = 523.5;
int F = 349;
int D = 294;
int ServoPin = 4;
int ServoPosition;

Servo towerServo;

MFRC522 reader(SDAPIN, RESETPIN);   // Create MFRC522 instance.

MFRC522::MIFARE_Key key;
 
void setup() 
{
  Serial.begin(9600);   // Initiate a serial communication
  SPI.begin();      // Initiate  SPI bus
  reader.PCD_Init();  // Initialize MFRC522 Hardware
  pinMode(GLIGHT,OUTPUT);
  pinMode(RLIGHT,OUTPUT);
  towerServo.attach(ServoPin); // We have indicated that the data pin of the servo motor is connected to pin 4 of the Arduino.
  towerServo.write(0);


}
void loop() 
{
   do {
       //Call the getID function until the read is successful
     successRead = getID(); 
   }
  while (!successRead);  
  delay(1000);
}

int getID() {
 // Look for new cards, if there is no card, then return 0;
  if ( ! reader.PICC_IsNewCardPresent()) { 
    return 0;
  }
  // Select one of the cards
  if ( ! reader.PICC_ReadCardSerial()) {
    return 0;
  }
  
  else
  {  
    check();
    return 1;
  }
}

int check()
{
    int address=0;
    
    for (int i = 0; i < reader.uid.size; i++) 
    {
       readCard[i] = reader.uid.uidByte[i];
    }

    while(EEPROM.read(address)!=0)
    {
        counter=0;
        
        for(int i=0;i<4;i++)
        {
            if(EEPROM.read(address)==readCard[i])
            {
              counter++;
            }
          address+=1;
         }

        if(counter==4)
        {
         result=true;
         break;
        } 
     }
     
      if(result==true)
      {
        Serial.println("Door is opening...");    
        for(int i=0;i<4;i++)
        {
          Serial.print(readCard[i],HEX);
          Serial.print(" ");
          }
          Serial.println("");
        digitalWrite(GLIGHT,HIGH);
        tone(buzzerPin, D);
        delay(200);
        tone(buzzerPin, F);
        delay(200);
        tone(buzzerPin, C);
        delay(400);
        noTone(buzzerPin);
        result=false;
        for(int i=1;i<=130;i++)
        {
          towerServo.write(i);
          delay(30);
        }
        
        delay(1000);

        for(int i=130;i>=0;i--)
        {
          towerServo.write(i);
          delay(10);
        }
        
        digitalWrite(GLIGHT,LOW);
        Serial.println("Door is closed.");    
      }

      else
      {
        for(int i=0;i<4;i++)
        {
          Serial.print(readCard[i],HEX);
          Serial.print(" ");
        }
        Serial.println("");
        digitalWrite(RLIGHT,HIGH);
        for(int i=0;i<7;i++)
        {
           tone(buzzerPin, F);
           delay(100);
           noTone(buzzerPin); 
           delay(50);        
        }
        digitalWrite(RLIGHT,LOW);
       }   
       address=0;
}
       
