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
using MongoDB.Driver;
using MongoDB.Bson;
using System.Net.Mail;

namespace COMPX323_APP
{
    public partial class AddUserInterface : Form
    {
        //Stores the staff username
        private string loginUser = "";
        string ConString;
        MongoClient dbClient;
        IMongoDatabase mongoDB;
        public AddUserInterface(string login, String Ver)
        {
            ConString = "<MongoDBConString>";
            dbClient = new MongoClient(ConString);
            mongoDB = dbClient.GetDatabase("COMPX323");
            InitializeComponent();
            dateTimePickerEOrS.Visible = false;
            labelEmploymentOrSignup.Visible = false;
            labelHourlySalary.Visible = false;
            numericUpDownSalary.Visible = false;
            loginUser = login;
            //Sets to either use SQL or MongoDB
            if(Ver == "SQL")
            {
                radioButtonSQL.Checked = true;
            }
            else if (Ver == "MongoDB")
            {
                radioButtonMongoDB.Checked = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Stores the varibles for the
            DateTime nSignup;
            DateTime nHireDate;
            //Regex for checking the phone number
            string rPhone = @"^\(\d{2}\)\d{7}$";
            //Regex for checking addresses
            string rAddress = @"^[0-9]{1,5} [A-Za-z]{2,32}[ ]{0,1}[A-Za-z]{0,32}$";
            //Regex for checking addresses
            string rPostCode = @"^[0-9][0-9][0-9][0-9]$";
            //Reads the values and trims them
            string NUserName = textBoxLoginName.Text.Trim();
            string NPassword = textBoxPassword.Text.Trim();
            string NFname = textBoxFName.Text.Trim();
            string NLName = textBoxLName.Text.Trim();
            string NPhonenum = textBoxPhone.Text.Trim();
            string NEmail = textBoxEmail.Text.Trim();
            string NStreetAddress = textBoxStreet.Text.Trim();
            string NCity = textBoxCity.Text.Trim();
            string NPostcode = textBoxPostCode.Text.Trim();
            DateTime NDOB = dateTimePickerDOB.Value;
            decimal NHourlySalary = numericUpDownSalary.Value;
            //Checks that a user has selected a button
            if (radioButtonCustomer.Checked)
            {
                //Compares the birthdate to the signup date (With the minimum signup age being 13 or older
                if (dateTimePickerDOB.Value.Year > (dateTimePickerEOrS.Value.Year -13))
                {
                    MessageBox.Show("Error: Customer is either not old enough to signup or date fields are incorrectly entered.");
                    return;
                }
            }
            else if (radioButtonStaff.Checked)
            {
                //Compares the birthdate to the employment date (With the minimum working age being 16 or older)
                if (dateTimePickerDOB.Value.Year > (dateTimePickerEOrS.Value.Year - 16))
                {
                    MessageBox.Show("Error: Staff is either not old enough to work here or date fields are incorrectly entered.");
                    return;
                }
                else if (NHourlySalary >= 100 || NHourlySalary <= 9)
                {
                    //Lets the user know that only number can be input
                    MessageBox.Show("Error: Please enter a valid and reasonable Hourly Salary");
                    return;
                }
            }
            //If none are selected then give the user an error message and return
            else
            {
                MessageBox.Show("Error: Please Select Staff or Customer.");
                return;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(NPhonenum, rPhone) != true)
            {
                //Lets the user know that only number can be input
                MessageBox.Show("Error: Please enter phone number in the correct format <(NN)NNNNNNN>");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(NStreetAddress, rAddress) != true)
            {
                //Lets the user know that only number can be input
                MessageBox.Show("Error: Please enter a valid street adddress in form of <Number/Letter> <Street> <StreetPart2(Optional)>");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(NPostcode, rPostCode) != true)
            {
                //Lets the user know that only number can be input
                MessageBox.Show("Error: Please enter a valid post code 4 Digits long");
                return;
            }
            try
            {
                MailAddress m = new MailAddress(textBoxEmail.Text);
            }
            //Performs the regex to check the different fields
            catch
            {
                MessageBox.Show("Error: Please enter email in the correct format");
                return;
            }
            //Checks if any of the fields are blank
            if (NUserName == "" || NPassword == "" || NFname == "" || NLName == "" || NPhonenum == "" || NEmail == "" || NStreetAddress == "" || NCity == "")
            {
                MessageBox.Show("Error: 1 or more fields do not have input, please fill out the entire form");
                return;
            }
            //Checks if being peformed by MongoDB or SQL
            if (radioButtonMongoDB.Checked)
            {
                var Users = mongoDB.GetCollection<BsonDocument>("UserAccount");
                //Checks that there does not exist a user with the same loginname
                var userQStaff = new BsonDocument
                    {
                            { "StaffLoginName", NUserName }
                    };
                var resultDocStaff = Users.Find(userQStaff).ToList();
                //Checks the size of the list
                var userQCust = new BsonDocument
                    {
                            { "CustLoginName", NUserName }
                    };
                var resultDocCust = Users.Find(userQCust).ToList();
                if (resultDocStaff.Count >= 1 || resultDocCust.Count >= 1)
                {
                    MessageBox.Show("Error: Username already exists in database.");
                    return;
                }
                BsonDocument UserDoc = new BsonDocument();
                //If Staff / Customer selected
                if (radioButtonCustomer.Checked)
                {
                    nSignup = dateTimePickerDOB.Value;
                    UserDoc.Add(new BsonElement("CustLoginName", NUserName));
                    UserDoc.Add(new BsonElement("JoinDate", nSignup));
                }
                else if (radioButtonStaff.Checked)
                {
                    nHireDate = dateTimePickerEOrS.Value;
                    UserDoc.Add(new BsonElement("StaffLoginName", NUserName));
                    UserDoc.Add(new BsonElement("HourlySalary", NHourlySalary));
                    UserDoc.Add(new BsonElement("EmploymentDate", nHireDate));
                }
                //Creates an empty array of repairs
                BsonArray repairDoc = new BsonArray();
                //Adds each of the atributes which are shared between staff and customers
                UserDoc.Add(new BsonElement("Password", NPassword));
                UserDoc.Add(new BsonElement("FName", NFname));
                UserDoc.Add(new BsonElement("LName", NLName));
                UserDoc.Add(new BsonElement("Phone", NPhonenum));
                UserDoc.Add(new BsonElement("EmailAddress", NEmail));
                UserDoc.Add(new BsonElement("City", NStreetAddress));
                UserDoc.Add(new BsonElement("PostCode", NCity));
                UserDoc.Add(new BsonElement("DateOfBirth", NDOB));
                UserDoc.Add(new BsonElement("repair", repairDoc));
                Users.InsertOne(UserDoc);

            }
            else if (radioButtonSQL.Checked)
            {
                //Checks first that there does not exist a user with the same user names
                SQL.selectQuery("SELECT LoginName FROM UserAccount WHERE LoginName = '" + NUserName + "'");
                if (SQL.dr.HasRows)
                {
                    MessageBox.Show("Error: Username already exists in database.");
                    return;
                }
                //Peforms a insert query to perfrom the written
                string AddUserS = "INSERT INTO UserAccount VALUES ('" + NUserName + "', '" + NPassword + "', '" + NFname + "', '" + NLName + "', '" + NPhonenum + "', '" + NEmail + "', '" + NStreetAddress + "', '" + NCity
                + "', " + NPostcode + ", to_date('" + NDOB.Year + "/" + NDOB.Month + "/" + NDOB.Day + "', 'yyyy/mm/dd'))";
                Console.WriteLine(AddUserS);
                SQL.executeQuery(AddUserS);
                //Depending on which radio button is selected, add either a Customer or Staff member
                if (radioButtonCustomer.Checked)
                {
                    nSignup = dateTimePickerDOB.Value;
                    string customer = "INSERT INTO Customer VALUES('" + NUserName + "', to_date('" + nSignup.Year + "/" + nSignup.Month + "/" + nSignup.Day + "', 'yyyy/mm/dd'))";
                    SQL.executeQuery(customer);
                    //For debugging pourposes, check that the user was properly added
                    SQL.selectQuery("SELECT LoginName FROM Customer WHERE LoginName = '" + NUserName + "'");
                    if (SQL.dr.HasRows)
                    {
                        SQL.dr.Read();
                        string loginname = SQL.dr[0].ToString();
                        MessageBox.Show(loginname + "  added to database!");
                    }
                }
                else if (radioButtonStaff.Checked)
                {
                    nHireDate = dateTimePickerEOrS.Value;
                    string staff = "INSERT INTO Staff VALUES('" + NUserName + "','" + NHourlySalary + "', to_date('" + nHireDate.Year + "/" + nHireDate.Month + "/" + nHireDate.Day + "', 'yyyy/mm/dd'))";
                    SQL.executeQuery(staff);
                    //For debugging pourposes, check that the user was properly added
                    SQL.selectQuery("SELECT LoginName FROM Customer WHERE LoginName = '" + NUserName + "'");
                    if (SQL.dr.HasRows)
                    {
                        SQL.dr.Read();
                        string loginname = SQL.dr[0].ToString();
                        MessageBox.Show(loginname + "  added to database!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error! Please select Database (MongoDB or SQL)");
            }
        }

        private void radioButtonCustomer_CheckedChanged(object sender, EventArgs e)
        {
            labelHourlySalary.Visible = false;
            numericUpDownSalary.Visible = false;
            labelEmploymentOrSignup.Text = "Signup Date:";
            labelEmploymentOrSignup.Visible = true;
            dateTimePickerEOrS.Visible = true;
        }

        private void radioButtonStaff_CheckedChanged(object sender, EventArgs e)
        {
            labelHourlySalary.Visible = true;
            numericUpDownSalary.Visible = true;
            labelEmploymentOrSignup.Text = "Hire Date:";
            labelEmploymentOrSignup.Visible = true;
            dateTimePickerEOrS.Visible = true;
        }

        //Performs regex to check for invalid inputs

        private void textBoxPostCode_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxPostCode.Text, "[^0-9]"))
            {
                //Lets the user know that only number can be input
                MessageBox.Show("Please only enter Numbers with no space for Postcode");
                textBoxPostCode.Text = textBoxPostCode.Text.Remove(textBoxPostCode.Text.Length - 1);
                return;
            }
        }

        private void textBoxLoginName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxLoginName.Text, "[^0-9A-Za-z]"))
            {
                //Lets the user know that only number can be input
                MessageBox.Show("Please only enter Leters and Numbers with no spaces for Username");
                textBoxLoginName.Text = textBoxLoginName.Text.Remove(textBoxLoginName.Text.Length - 1);
                return;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxPassword.Text, "[^0-9A-Za-z]"))
            {
                //Lets the user know that only number can be input
                MessageBox.Show("Please only enter Leters and Numbers with no spaces for NAME");
                textBoxPassword.Text = textBoxPassword.Text.Remove(textBoxPassword.Text.Length - 1);
                return;
            }
        }

        private void textBoxFName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxFName.Text, "[^A-Za-z]"))
            {
                //Lets the user know that only number can be input
                MessageBox.Show("Please only enter Leters with no spaces First Name");
                textBoxFName.Text = textBoxFName.Text.Remove(textBoxFName.Text.Length - 1);
                return;
            }
        }

        private void textBoxLName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxLName.Text, "[^A-Za-z]"))
            {
                //Lets the user know that only number can be input
                MessageBox.Show("Please only enter Leters with no spaces for Last Name");
                textBoxLName.Text = textBoxLName.Text.Remove(textBoxLName.Text.Length - 1);
                return;
            }
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxPhone.Text, "[^0-9()]"))
            {
                //Lets the user know that only number can be input
                MessageBox.Show("Please only enter Numbers with no spaces and with extention in ( ) for Phone");
                textBoxPhone.Text = textBoxPhone.Text.Remove(textBoxPhone.Text.Length - 1);
                return;
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxEmail.Text, "[^A-Za-z0-9@/.]"))
            {
                //Lets the user know that only number can be input
                MessageBox.Show("Please only enter Leters Numbers and @ . symbols for Email");
                textBoxEmail.Text = textBoxEmail.Text.Remove(textBoxEmail.Text.Length - 1);
                return;
            }
        }

        private void textBoxStreet_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxStreet.Text, "[^0-9A-Za-z ]"))
            {
                //Lets the user know that only number can be input
                MessageBox.Show("Please only enter Numbers and Letters for Street");
                textBoxStreet.Text = textBoxStreet.Text.Remove(textBoxStreet.Text.Length - 1);
                return;
            }
        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxCity.Text, "[^A-Za-z]"))
            {
                //Lets the user know that only number can be input
                MessageBox.Show("Please only enter Leters with no spaces for City");
                textBoxCity.Text = textBoxCity.Text.Remove(textBoxCity.Text.Length - 1);
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

        private void numericUpDownSalary_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddUserInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
