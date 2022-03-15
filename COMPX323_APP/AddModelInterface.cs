using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace COMPX323_APP
{
    public partial class AddModelInterface : Form
    {
        //Stores the staff username
        private string loginUser = "";

        public AddModelInterface(string login)
        {
            InitializeComponent();
            loginUser = login;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Regex for checking model numbers
            string rModel = @"^[A-Za-z0-9/-]{1,32}\s$";
            //Regex for checking brand
            string rBrand = @"^[A-Za-z]{1,16}\s$";
            {
                string NModel = textBoxModelName.Text.Trim();
                string NBrand = textBoxBrand.Text.Trim();
                if (System.Text.RegularExpressions.Regex.IsMatch(textBoxModelName.Text, rModel) != true)
                {
                    //Lets the user know that only number can be input
                    MessageBox.Show("Error: Please enter Model correctly");
                    return;
                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(textBoxBrand.Text, rBrand) != true)
                {
                    //Lets the user know that only number can be input
                    MessageBox.Show("Error: Please enter Brand correctly");
                    return;
                }
                //Checks first that there does not exist a model number with the same value 
                SQL.selectQuery("SELECT ModelNumber FROM DeviceModel WHERE ModelNumber = '" + NModel + "'");
                if (SQL.dr.HasRows)
                {
                    SQL.dr.Read();
                    string exisingModel = SQL.dr[0].ToString();
                    MessageBox.Show("'" + exisingModel + "' already exists on the database!");
                    return;
                }
                //Peforms a insert query to perfrom the written
                string AddModel = "INSERT INTO DeviceModel VALUES ('" + NModel + "', '" + NBrand + "')";
                SQL.executeQuery(AddModel);
                //Checks that the model is now on the database
                SQL.selectQuery("SELECT ModelNumber FROM DeviceModel WHERE ModelNumber = '" + NModel + "'");
                if (SQL.dr.HasRows)
                {
                    SQL.dr.Read();
                    string exisingModel = SQL.dr[0].ToString();
                    MessageBox.Show("'" + exisingModel + "' successfully added!");
                }
            }

        }

        private void textBoxBrand_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxBrand.Text, "[^0-9A-Za-z]"))
            {
                //Lets the user know that only number can be input
                MessageBox.Show("Please only enter Numbers with no space for Brand");
                textBoxBrand.Text = textBoxBrand.Text.Remove(textBoxBrand.Text.Length - 1);
                return;
            }
        }

        private void textBoxModelName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxModelName.Text, "[^0-9A-Za-z/-]"))
            {
                //Lets the user know that only number can be input
                MessageBox.Show("Please only enter Leters and Numbers with no spaces for Model Number");
                textBoxModelName.Text = textBoxModelName.Text.Remove(textBoxModelName.Text.Length - 1);
                return;
            }
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffActions display = new StaffActions(loginUser);
            display.ShowDialog();
            this.Close();
        }
    }
}
