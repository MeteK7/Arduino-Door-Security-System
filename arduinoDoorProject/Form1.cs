using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using MySql.Data.MySqlClient;

namespace arduinoDoorProject
{
    public partial class Form1 : Form
    {
        private SerialPort myPort;
        private string in_data;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; 
            CboPersonLoad();
        }
        MySqlConnection con = new MySqlConnection("Database=localhost;username=Project;password=123456;database=arduino;");

        private void CboPersonLoad()
        {
            con.Open();
            MySqlCommand pullData = new MySqlCommand("SELECT * FROM personinfo", con);
            MySqlDataReader readData = pullData.ExecuteReader();

            while (readData.Read())
            {
                cboPerson.Items.Add(readData["fullname"]);
            }
            con.Close();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            myPort = new SerialPort();
            myPort.BaudRate = 9600;
            myPort.PortName = port_name_tb.Text;
            myPort.Parity = Parity.None;
            myPort.DataBits = 8;
            myPort.StopBits = StopBits.One;
            myPort.DataReceived += myPort_DataReceived;
            try {
                myPort.Open();
                data_tb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void myPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            in_data = myPort.ReadLine();

            this.Invoke(new EventHandler(displaydata_event));

        }
        string fullName = "No Name";
        
        int entrance;

        private void displaydata_event(object sender, EventArgs e)
        {
            if (in_data=="Door is opening...\r")
            {
                lblStatus.Text = "Status: Door is opening...";
            }
            else if (in_data == "Door is closed.\r")
            {
                lblStatus.Text = "Status: Door is closed.";
            }
            else
            {
                dispData();
            }
        }

        private void dispData()
        {
            DateTime currentDate = DateTime.Now;
            data_tb.AppendText(currentDate + "\t\t" + in_data + "\n");
            con.Open();
            MySqlCommand pullData = new MySqlCommand("SELECT * FROM personinfo", con);
            MySqlDataReader readData = pullData.ExecuteReader();
            while (readData.Read())
            {
                string temp = readData["cardnum"].ToString() + " \r";

                if (in_data.ToString() == temp)
                {
                    entrance = Convert.ToInt32(readData["entrance"]);
                    if (entrance == 0)
                    {
                        fullName = readData["fullname"].ToString();
                        txtPersonAvail.AppendText(fullName + "\t\t" + "In\n");
                    }
                    else
                    {
                        txtPersonAvail.AppendText(readData["fullname"].ToString() + "\t\t" + "Out\n");
                    }
                    con.Close();
                    savePerson();
                    break;
                }
            }
            con.Close();
        }

        private void savePerson()
        {
            DateTime entranceDate = DateTime.Now;
            DateTime currentDate = DateTime.Now;
            

            if (entrance==0)
            {  
                con.Open();
                MySqlCommand insertData = new MySqlCommand("INSERT INTO dailyinfo (cardnum,fullname,entrancedate) values ('" + in_data + "','" + fullName + "','" + currentDate + "')", con);
                insertData.ExecuteNonQuery();

                MySqlCommand updateData = new MySqlCommand("UPDATE personinfo set entrance='" + 1 + "'WHERE fullname='" + fullName + "';", con);
                updateData.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                con.Open();
                MySqlCommand pullData = new MySqlCommand("SELECT * FROM dailyinfo WHERE cardnum='" + in_data + "';", con);
                MySqlDataReader readData = pullData.ExecuteReader();
                while (readData.Read())
                {
                    string temp = readData["cardnum"].ToString();
                    fullName = readData["fullname"].ToString();

                    if (in_data.ToString() == temp)
                    {
                        entranceDate = Convert.ToDateTime(readData["entrancedate"]);
                    }
                }
                con.Close();

                TimeSpan nod = DateTime.Parse(currentDate.ToString()).Subtract(DateTime.Parse(entranceDate.ToString()));
                double availability = nod.TotalMinutes;
                con.Open();
                MySqlCommand insertData = new MySqlCommand("UPDATE dailyinfo set exitdate='"+ currentDate + "',availability='" + nod + "'WHERE entrancedate='" + entranceDate + "';", con);
                insertData.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlCommand updateData = new MySqlCommand("UPDATE personinfo set entrance='" + 0 + "'WHERE fullname='" + fullName + "';", con);
                updateData.ExecuteNonQuery();
                con.Close();
            }

        }
        private void stop_btn_Click(object sender, EventArgs e)
        {
            try
            {
                myPort.Close();
            }
            catch (Exception ex2)
            {

                MessageBox.Show(ex2.Message, "Error");
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            personRegister personReg = new personRegister();
            personReg.Show();
        }

        private void cboPerson_DropDownClosed(object sender, EventArgs e)
        {
            if (cboPerson.SelectedIndex!=-1)
            {
                lvPerson.Items.Clear();
                var people = GetLvPeople();
                foreach (var person in people)
                {
                    var row = new string[] { person.ID, person.Name, person.Entrance, person.Exit, person.Availability };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = person;
                    lvPerson.Items.Add(lvi);
                }
            }
        }
        private List<LvPersonInfo> GetLvPeople()
        {
            var list = new List<LvPersonInfo>();
            con.Open();
            MySqlCommand pullData = new MySqlCommand("SELECT * FROM dailyinfo WHERE fullname = '" + cboPerson.SelectedItem.ToString() + "'", con);
            MySqlDataReader readData = pullData.ExecuteReader();

            while (readData.Read())
            {
                list.Add(new LvPersonInfo() { ID = readData["cardnum"].ToString(), Name = readData["fullname"].ToString(), Entrance = readData["entrancedate"].ToString(), Exit = readData["exitdate"].ToString(), Availability = readData["availability"].ToString()});
            }
            con.Close();
            return list;
        }

        private void btnManagePerson_Click(object sender, EventArgs e)
        {
            personRegister Reg = new personRegister();
            Reg.Show();
        }
    }
    class LvPersonInfo
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Entrance { get; set; }
        public string Exit { get; set; }
        public string Availability { get; set; }
    }
}
