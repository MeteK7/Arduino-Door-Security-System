using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace arduinoDoorProject
{
    public partial class personRegister : Form
    {
        public personRegister()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        MySqlConnection con = new MySqlConnection("Database=localhost;username=Project;password=123456;database=arduino;");

        private void btnSavePerson_Click(object sender, EventArgs e)
        {
            if (txtCardNumber.Text == "" || txtFullName.Text == "")
            {
                lblWarning.Text = "";
                lblWarning.Text = "Please fill the all fields to add someone.";
            }
            else
            {
                con.Open();
                MySqlCommand insertData = new MySqlCommand("INSERT INTO personinfo (fullname,cardnum,entrance) values ('" + txtFullName.Text + "','" + txtCardNumber.Text + "','" + 0 + "')", con);
                insertData.ExecuteNonQuery();
                con.Close();
                lblWarning.Text = "Inserted Successfully!";
            }
            clearTexts();
        }

        bool exist;
        private void btnDelPerson_Click(object sender, EventArgs e)
        {
            if (txtCardNumber.Text == "" || txtFullName.Text == "")
            {
                lblWarning.Text = "";
                lblWarning.Text = "Please fill the all fields to delete a person.";
            }

            else
            {
                con.Open();
                MySqlCommand pullData = new MySqlCommand("SELECT * FROM personinfo", con);
                MySqlDataReader readData = pullData.ExecuteReader();
                while (readData.Read())
                {
                    string cardNum = readData["cardnum"].ToString();
                    string fullName = readData["fullname"].ToString();

                    if (txtCardNumber.Text != cardNum || txtFullName.Text != fullName)
                    {
                        exist = false;
                    }
                    else
                    {
                        exist = true;
                        break;
                    }
                }
                con.Close();
                checkDelPerson();
                clearTexts();
            }
        }

        private void clearTexts()
        {
            txtCardNumber.Text = "";
            txtFullName.Text = "";
        }

        private void checkDelPerson()
        {
            if (exist == false)
            {
                lblWarning.Text = "There is no such a person to delete.";
            }
            else
            {
                con.Open();
                MySqlCommand insertData = new MySqlCommand("DELETE FROM personinfo WHERE cardnum='" + txtCardNumber.Text + "';", con);
                insertData.ExecuteNonQuery();
                con.Close();
                lblWarning.Text = "Deleted Successfully!";
            }
        }
    }
}
