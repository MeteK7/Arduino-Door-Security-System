#include <SPI.h>
#include <MFRC522.h>
#include <EEPROM.h>

#define RESETPIN 9
#define SDAPIN 10

byte readCard[4];
int successRead;
int address=0;
int unique;
MFRC522 reader(SDAPIN, RESETPIN);   // Create MFRC522 instance.

MFRC522::MIFARE_Key key;
 
void setup() 
{
  Serial.begin(9600);   // Initiate a serial communication
  SPI.begin();      // Initiate  SPI bus
  reader.PCD_Init();  // Initialize MFRC522 Hardware

}
void loop() 
{
    Serial.println("Read the card,please: ");

    do {
    //Call the getID function until the read is successful
    successRead = getID(); 
  }
  while (!successRead);
  
  unique = check();

  if(unique==1)
  {
   for ( int i = 0; i < reader.uid.size; i++ )
    {

       //save the card's UID to EEPROM
        EEPROM.write(address, readCard[i]);
        address++;
    }
    Serial.println("The card has been saved to EEPROM."); 
  }
  address=0;
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
  Serial.print("Card's UID: ");
  //Read the Card's UID and write it as bytes, the write it on the serial monitor.
  for (int i = 0; i < reader.uid.size; i++) {
    readCard[i] = reader.uid.uidByte[i];
    Serial.print(readCard[i], HEX);
  }
  Serial.println("");
  //Stop reading the Card and return 1. (Reading is successful!)
  reader.PICC_HaltA();
  return 1;
}
int check(){
      while(EEPROM.read(address)!=0)
      {
          if(EEPROM.read(address)==readCard[0])
            {
              Serial.println("You have already saved this card!");
              return 0;
            }
          address+=4;
       }
        return 1;
  }
