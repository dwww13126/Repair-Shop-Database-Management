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
    public partial class AddRepairInterface : Form
    {
        //Stores the staff username
        private string loginUser = "";
        public AddRepairInterface(string login)
        {
            InitializeComponent();
            loginUser = login;
            //populates the Staff, Customer and DeviceModel comboBoxes
            string Customer = "SELECT LoginName FROM Customer";
            SQL.selectQuery(Customer);
            //WHile there are results, add them to the drop down
            if(SQL.dr.HasRows){
                while (SQL.dr.Read())
                {
                    comboBoxCustomer.Items.Add(SQL.dr[0]);
                }
            }
            else
            {
                MessageBox.Show("Error: No Customers on DB");
                return;
            }
            string DeviceModel = "SELECT ModelNumber FROM DeviceModel";
            SQL.selectQuery(DeviceModel);
            if (SQL.dr.HasRows) {
                //WHile there are results, add them to the drop down
                while (SQL.dr.Read())
                {
                    comboBoxModel.Items.Add(SQL.dr[0]);
                }
            }
            else
            {
                MessageBox.Show("Error: No ModelNumbers on DB");
                return;
            }
            string Staff = "SELECT LoginName FROM Staff";
            SQL.selectQuery(Staff);
            if (SQL.dr.HasRows)
            {
                //WHile there are results, add them to the drop down
                while (SQL.dr.Read())
                {
                    comboBoxStaff.Items.Add(SQL.dr[0]);
                }
            }
            else
            {
                MessageBox.Show("Error: No Staff on DB");
                return;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Reads the data
            string CUserName = comboBoxCustomer.Text;
            string SUserName = comboBoxStaff.Text;
            string Model = comboBoxModel.Text;
            if (Model == "")
            {
                MessageBox.Show("Please select a Model");
                return;
            }
            else if (CUserName == "")
            {
                MessageBox.Show("Please select a Customer username");
                return;
            }
            else if (SUserName == "")
            {
                MessageBox.Show("Please select a Staff username");
                return;
            }
            //Stores the varibles for the repair date time
            DateTime RepairDate = dateTimePickerRepairDate.Value;
            string repair = "INSERT INTO RepairJob VALUES(Repair_seq.NEXTVAL, to_date('" + RepairDate.Year + "/" + RepairDate.Month + "/" + RepairDate.Day + "', 'yyyy/mm/dd'), '" + CUserName + "', '" + SUserName + "', '" + Model + "')";
            SQL.executeQuery(repair);
            MessageBox.Show("Repair job added!");
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
