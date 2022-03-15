using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace COMPX323_APP
{
    public partial class StaffActions : Form
    {
        //Stores the staff username
        private string loginUser = "";
        string ConString;
        MongoClient dbClient;
        IMongoDatabase mongoDB;

        public StaffActions(string login)
        {
            ConString = "<MongoDBConString>";
            dbClient = new MongoClient(ConString);
            mongoDB = dbClient.GetDatabase("COMPX323");
            InitializeComponent();
            labelLogin.Text = "User Name: " + login;
            loginUser = login;
            //Performs a query to populate the brand types 
            string s = "SELECT DISTINCT Brand FROM DeviceModel";
            SQL.selectQuery(s);
            //WHile there are results, add them to the drop down
            if (SQL.dr.HasRows)
            {
                while (SQL.dr.Read())
                {
                    comboBoxBrands.Items.Add(SQL.dr[0]);
                }
            }
            listViewResults.View = View.Details;
        }
        private void buttonAddViewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUserInterface display = new AddUserInterface(loginUser, "SQL");
            display.ShowDialog();
            this.Close();
        }

        private void buttonBrandSelect_Click(object sender, EventArgs e)
        {
            //Reads in the value from the dropdown
            string BrandN = comboBoxBrands.Text.Trim();
            if (BrandN == "")
            {
                MessageBox.Show("Please select a Brand!");
                return;
            }
            string s = "SELECT DISTINCT U.LoginName, U.FName, U.LName FROM UserAccount U, RepairJob R WHERE R.StaffLogin = '" + loginUser +
                "' AND U.LoginName = R.CustomerLogin AND R.ModelNumber IN (SELECT D.ModelNumber FROM DeviceModel D WHERE D.Brand = '" + BrandN + "')";
            SQL.selectQuery(s);

            listViewResults.Clear();
            listViewResults.Columns.Add("User Name", 150, HorizontalAlignment.Left);
            listViewResults.Columns.Add("First Name", 150, HorizontalAlignment.Left);
            listViewResults.Columns.Add("Last Name", 150, HorizontalAlignment.Left);
            if (SQL.dr.HasRows)
            {
                while (SQL.dr.Read())
                {
                    string UName = SQL.dr[0].ToString();
                    string FName = SQL.dr[1].ToString();
                    string LName = SQL.dr[2].ToString();

                    var ResultItem = new ListViewItem(new[] { UName, FName, LName });
                    listViewResults.Items.Add(ResultItem);
                }
            }
        }

        private void buttonBeforeID_Click(object sender, EventArgs e)
        {
            //Reads in the value from the dropdown
            string ID = numericUpDownID.Text.Trim();
            if(ID == "")
            {
                MessageBox.Show("Please enter an ID!");
                return;
            }
            string check = "SELECT R1.repairdate FROM RepairJob R1 WHERE R1.RepairID = " + ID;
            SQL.selectQuery(check);
            if (SQL.dr.HasRows != true)
            {
                MessageBox.Show("Repair ID '" + ID + "' does not exsist!");
                return;
            }
            string s = "SELECT R.RepairDate, R.CustomerLogin, R.ModelNumber FROM RepairJob R WHERE R.StaffLogin = '" + loginUser +
                "' AND R.repairdate < (SELECT R1.repairdate FROM RepairJob R1 WHERE R1.RepairID = " + ID + ")";
            SQL.selectQuery(s);
            listViewResults.Clear();
            listViewResults.Columns.Add("Date", 150, HorizontalAlignment.Left);
            listViewResults.Columns.Add("User Name", 150, HorizontalAlignment.Left);
            listViewResults.Columns.Add("Model", 150, HorizontalAlignment.Left);
            if (SQL.dr.HasRows)
            {
                while (SQL.dr.Read())
                {
                    string Date = SQL.dr[0].ToString();
                    string UserName = SQL.dr[1].ToString();
                    string Model = SQL.dr[2].ToString();

                    var ResultItem = new ListViewItem(new[] { Date, UserName, Model });
                    listViewResults.Items.Add(ResultItem);
                }
            }
            else
            {
                MessageBox.Show("No Repairs before repair ID: '" + ID + "' exsist");
                return;
            }
        }

        private void buttonAfterID_Click(object sender, EventArgs e)
        {
            //Reads in the value from the dropdown
            string ID = numericUpDownID.Text.Trim();
            if (ID == "")
            {
                MessageBox.Show("Please enter an ID!");
                return;
            }
            string check = "SELECT R1.repairdate FROM RepairJob R1 WHERE R1.RepairID = " + ID;
            SQL.selectQuery(check);
            if (SQL.dr.HasRows != true)
            {
                MessageBox.Show("Repair ID '" + ID + "' does not exsist!");
                return;
            }
            string s = "SELECT R.RepairDate, R.CustomerLogin, R.ModelNumber FROM RepairJob R WHERE R.StaffLogin = '" + loginUser +
            "' AND R.repairdate > (SELECT R1.repairdate FROM RepairJob R1 WHERE R1.RepairID = " + ID + ")";
            SQL.selectQuery(s);
            listViewResults.Clear();
            listViewResults.Columns.Add("Date", 150, HorizontalAlignment.Left);
            listViewResults.Columns.Add("User Name", 150, HorizontalAlignment.Left);
            listViewResults.Columns.Add("Model", 150, HorizontalAlignment.Left);
            if (SQL.dr.HasRows)
            {
                while (SQL.dr.Read())
                {
                    string Date = SQL.dr[0].ToString();
                    string UserName = SQL.dr[1].ToString();
                    string Model = SQL.dr[2].ToString();

                    var ResultItem = new ListViewItem(new[] { Date, UserName, Model });
                    listViewResults.Items.Add(ResultItem);
                }
            }
            else
            {
                MessageBox.Show("No Repairs after repair ID: '" + ID + "' exsist");
                return;
            }
        }

        private void buttonNewestServed_Click(object sender, EventArgs e)
        {
            string s = "SELECT C.LoginName FROM Customer C WHERE C.JoinDate = (SELECT MAX(C2.JoinDate) FROM Customer C2)";
            SQL.selectQuery(s);
            if (SQL.dr.HasRows)
            {
                SQL.dr.Read();
                textBoxUserNameResult.Text = SQL.dr[0].ToString();
            }
            else
            {
                textBoxUserNameResult.Text = "";
                MessageBox.Show("You do not have any repairs linked to your Username");
                return;
            }
        }

        private void buttonOldestServed_Click(object sender, EventArgs e)
        {
            string s = "SELECT C.LoginName FROM Customer C WHERE C.JoinDate = (SELECT MIN(C2.JoinDate) FROM Customer C2)";
            SQL.selectQuery(s);
            if (SQL.dr.HasRows)
            {
                SQL.dr.Read();
                textBoxUserNameResult.Text = SQL.dr[0].ToString();
            }
            else
            {
                textBoxUserNameResult.Text = "";
                MessageBox.Show("You do not have any repairs linked to your Username");
                return;
            }
        }

        private void buttonLargestRepairServed_Click(object sender, EventArgs e)
        {
            string s = "SELECT R.CustomerLogin FROM RepairJob R WHERE R.StaffLogin = '" + loginUser
                + "' GROUP BY R.CustomerLogin ORDER BY COUNT(R.CustomerLogin) DESC FETCH FIRST 1 ROWS ONLY";
            SQL.selectQuery(s);
            if (SQL.dr.HasRows)
            {
                SQL.dr.Read();
                textBoxUserNameResult.Text = SQL.dr[0].ToString();
            }
            else
            {
                textBoxUserNameResult.Text = "";
                MessageBox.Show("You do not have any repairs linked to your Username");
                return;
            }
        }

        private void buttonUserSingularModel_Click(object sender, EventArgs e)
        {
            string s = "SELECT DISTINCT U.LoginName, U.FName, U.LName FROM UserAccount U, Customer C, RepairJob R WHERE C.LoginName = R.customerlogin AND U.LoginName = C.LoginName" +
               " AND EXISTS(SELECT R2.ModelNumber FROM RepairJob R2 WHERE R2.ModelNumber = R.ModelNumber AND R2.RepairID != R.RepairID)";
            SQL.selectQuery(s);
            listViewResults.Clear();
            listViewResults.Columns.Add("User Name", 150, HorizontalAlignment.Left);
            listViewResults.Columns.Add("FName", 150, HorizontalAlignment.Left);
            listViewResults.Columns.Add("LName", 150, HorizontalAlignment.Left);
            if (SQL.dr.HasRows)
            {
                while (SQL.dr.Read())
                {
                    string UName = SQL.dr[0].ToString();
                    string FName = SQL.dr[1].ToString();
                    string LName = SQL.dr[2].ToString();

                    var ResultItem = new ListViewItem(new[] { UName, FName, LName });
                    listViewResults.Items.Add(ResultItem);
                }
            }
            else
            {
                MessageBox.Show("No Matches Found");
                return;
            }
        }

        private void buttonUserNoYet_Click(object sender, EventArgs e)
        {
            string s = "SELECT DISTINCT U.LoginName, U.FName, U.LName FROM UserAccount U, Customer C WHERE U.LoginName = C.LoginName AND C.LoginName NOT IN (SELECT DISTINCT R.customerlogin FROM RepairJob R WHERE R.StaffLogin = '" + loginUser + "')";
            SQL.selectQuery(s);
            listViewResults.Clear();
            listViewResults.Columns.Add("User Name", 150, HorizontalAlignment.Left);
            listViewResults.Columns.Add("FName", 150, HorizontalAlignment.Left);
            listViewResults.Columns.Add("LName", 150, HorizontalAlignment.Left);
            if (SQL.dr.HasRows)
            {
                while (SQL.dr.Read())
                {
                    string UName = SQL.dr[0].ToString();
                    string FName = SQL.dr[1].ToString();
                    string LName = SQL.dr[2].ToString();

                    var ResultItem = new ListViewItem(new[] { UName, FName, LName });
                    listViewResults.Items.Add(ResultItem);
                }
            }
            else
            {
                MessageBox.Show("No Matches Found");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "SELECT R.CustomerLogin FROM RepairJob R WHERE R.StaffLogin = '" + loginUser
                + "' GROUP BY R.CustomerLogin ORDER BY COUNT(R.CustomerLogin) ASC FETCH FIRST 1 ROWS ONLY";
            SQL.selectQuery(s);
            if (SQL.dr.HasRows)
            {
                SQL.dr.Read();
                textBoxUserNameResult.Text = SQL.dr[0].ToString();
            }
            else
            {
                textBoxUserNameResult.Text = "";
                MessageBox.Show("You do not have any repairs linked to your Username");
                return;
            }
        }

        private void buttonUserHasPrev_Click(object sender, EventArgs e)
        {
            string s = "SELECT DISTINCT U.LoginName, U.FName, U.LName FROM UserAccount U, Customer C WHERE U.LoginName = C.LoginName AND C.LoginName IN (SELECT DISTINCT R.customerlogin FROM RepairJob R WHERE R.StaffLogin = '" + loginUser + "')";
            SQL.selectQuery(s);
            listViewResults.Clear();
            listViewResults.Columns.Add("User Name", 150, HorizontalAlignment.Left);
            listViewResults.Columns.Add("FName", 150, HorizontalAlignment.Left);
            listViewResults.Columns.Add("LName", 150, HorizontalAlignment.Left);
            if (SQL.dr.HasRows)
            {
                while (SQL.dr.Read())
                {
                    string UName = SQL.dr[0].ToString();
                    string FName = SQL.dr[1].ToString();
                    string LName = SQL.dr[2].ToString();

                    var ResultItem = new ListViewItem(new[] { UName, FName, LName });
                    listViewResults.Items.Add(ResultItem);
                }
            }
            else
            {
                MessageBox.Show("No Matches Found");
                return;
            }
        }

        private void buttonUserMultipleModels_Click(object sender, EventArgs e)
        {
            string s = "SELECT DISTINCT U.LoginName, U.FName, U.LName FROM UserAccount U, Customer C, RepairJob R WHERE C.LoginName = R.customerlogin AND U.LoginName = C.LoginName" +
   " AND EXISTS(SELECT R2.ModelNumber FROM RepairJob R2 WHERE R2.ModelNumber != R.ModelNumber)";
            SQL.selectQuery(s);
            listViewResults.Clear();
            listViewResults.Columns.Add("User Name", 150, HorizontalAlignment.Left);
            listViewResults.Columns.Add("FName", 150, HorizontalAlignment.Left);
            listViewResults.Columns.Add("LName", 150, HorizontalAlignment.Left);
            if (SQL.dr.HasRows)
            {
                while (SQL.dr.Read())
                {
                    string UName = SQL.dr[0].ToString();
                    string FName = SQL.dr[1].ToString();
                    string LName = SQL.dr[2].ToString();

                    var ResultItem = new ListViewItem(new[] { UName, FName, LName });
                    listViewResults.Items.Add(ResultItem);
                }
            }
            else
            {
                MessageBox.Show("No Matches Found");
                return;
            }
        }

        private void buttonAddViewRepairs_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRepairInterface display = new AddRepairInterface(loginUser);
            display.ShowDialog();
            this.Close();
        }

        private void buttonAddViewDevices_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddModelInterface display = new AddModelInterface(loginUser);
            display.ShowDialog();
            this.Close();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage display = new LoginPage();
            display.ShowDialog();
            this.Close();
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            string s = "SELECT R.RepairID, U.LoginName, R.RepairDate, R.ModelNumber FROM UserAccount U, RepairJob R WHERE R.StaffLogin = '" + loginUser + "' AND R.CustomerLogin = U.LoginName";
            SQL.selectQuery(s);
            listViewResults.Clear();
            listViewResults.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listViewResults.Columns.Add("User Name", 150, HorizontalAlignment.Left);
            listViewResults.Columns.Add("Date", 150, HorizontalAlignment.Left);
            listViewResults.Columns.Add("Model", 150, HorizontalAlignment.Left);
            if (SQL.dr.HasRows)
            {
                while (SQL.dr.Read())
                {
                    string ID = SQL.dr[0].ToString();
                    string UName = SQL.dr[1].ToString();
                    string Date = SQL.dr[2].ToString();
                    string Model = SQL.dr[3].ToString();
                    var ResultItem = new ListViewItem(new[] { ID, UName, Date, Model });
                    listViewResults.Items.Add(ResultItem);
                }
            }
            else
            {
                MessageBox.Show("No Matches Found");
                return;
            }
        }

        private void buttonUsersAssignedMongoDB_Click(object sender, EventArgs e)
        {
            var Users = mongoDB.GetCollection<BsonDocument>("UserAccount");
            var userQ = new BsonDocument
            {
                    { "StaffLoginName", loginUser }
            };
            List<BsonDocument> resultDoc = Users.Find(userQ).Limit(1).ToList();

            //Checks the size of the repair listlist
            if (resultDoc.Count != 0)
            {
                //Creates a dictionary for storing the data without duplicates
                Dictionary<string, string> user_names = new Dictionary<string, string>();
                BsonArray repairs = resultDoc.First().GetValue("repair").AsBsonArray;
                foreach (BsonDocument job in repairs)
                {
                    //Checks first if the user is already present 
                    string custLogin = job.GetValue("CustomerLogin").AsString;
                    //Checks if the dictionary does not contain the custLogin
                    if (user_names.ContainsKey(custLogin) != true)
                    {
                        user_names.Add(custLogin, "");
                    }
                }
                listViewResults.Clear();
                listViewResults.Columns.Add("Customer Login", 150, HorizontalAlignment.Left);
                //Once finished, output each of the key / values in the dictionary
                foreach (KeyValuePair<string, string> n in user_names)
                {
                    string login = n.Key;
                    var ResultItem = new ListViewItem(new[] { login });
                    listViewResults.Items.Add(ResultItem);
                }
            }
            else
            {
                MessageBox.Show("Error! User no longer on MongoDb database");
                return;
            }
        }

        private void buttonAfterMongoDB_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowRepairsMongoDB_Click(object sender, EventArgs e)
        {
            var Users = mongoDB.GetCollection<BsonDocument>("UserAccount");
            BsonDocument userQ = new BsonDocument{
            { "StaffLoginName", "ImStaffMember" }
            
            };
            List<BsonDocument> resultDoc = Users.Find(userQ).Limit(1).ToList();

            //Checks the size of the repair listlist
            if (resultDoc.Count != 0)
            {
                //Creates a dictionary for storing the data without duplicates
                Dictionary<string, string> user_names = new Dictionary<string, string>();
                BsonArray repairs = resultDoc.First().GetValue("repair").AsBsonArray;
                listViewResults.Clear();
                //If there are repairs which can are found
                if (repairs.Count >= 1)
                {
                    listViewResults.Columns.Add("ID", 50, HorizontalAlignment.Left);
                    listViewResults.Columns.Add("User Name", 150, HorizontalAlignment.Left);
                    listViewResults.Columns.Add("Date", 150, HorizontalAlignment.Left);
                    listViewResults.Columns.Add("Model", 150, HorizontalAlignment.Left);
                    //For each value in the BsonArray
                    foreach (BsonDocument job in repairs)
                    {
                        int RepairID = job.GetValue("RepairID").AsInt32;
                        string CustomerLogin = job.GetValue("CustomerLogin").AsString;
                        BsonDateTime RepairDate = job.GetValue("RepairDate").AsBsonDateTime;
                        string ModelNumber = job.GetValue("ModelNumber").AsString;
                        var ResultItem = new ListViewItem(new[] { RepairID.ToString(), CustomerLogin, RepairDate.ToString(), ModelNumber });
                        listViewResults.Items.Add(ResultItem);
                    }

                }
                else
                {
                    MessageBox.Show("Error! You have no repair jobs ");
                }

            }
            else
            {
                MessageBox.Show("Error! User no longer on MongoDb database");
                return;
            }
        }

        private void buttonMostServedMongo_Click(object sender, EventArgs e)
        {
            var Users = mongoDB.GetCollection<BsonDocument>("UserAccount");
            var userQ = new BsonDocument
            {
                    { "StaffLoginName", loginUser }
            };
            List<BsonDocument> resultDoc = Users.Find(userQ).Limit(1).ToList();

            //Checks the size of the repair listlist
            if (resultDoc.Count != 0)
            {
                //Creates a dictionary for storing the data without duplicates
                Dictionary<string, int> user_names = new Dictionary<string, int>();
                BsonArray repairs = resultDoc.First().GetValue("repair").AsBsonArray;
                if (repairs.Count != 0)
                {
                    foreach (BsonDocument job in repairs)
                    {
                        //Checks first if the user is already present 
                        string custLogin = job.GetValue("CustomerLogin").AsString;
                        //Checks if the dictionary does not contain the custLogin
                        if (user_names.ContainsKey(custLogin) != true)
                        {
                            user_names.Add(custLogin, 1);
                        }
                        //Otherwise increments the value of the count
                        else
                        {
                            int prev = user_names[custLogin];
                            user_names[custLogin] = prev + 1;
                        }
                    }
                    //Once finished, finds the most served custoimer based on the count
                    int highestCount = 0;
                    string highestUser = "";
                    foreach (KeyValuePair<string, int> n in user_names)
                    {
                        if (n.Value >= highestCount)
                        {
                            highestUser = n.Key;
                            highestCount = n.Value;
                        }
                    }
                    textBoxUserNameResult.Text = highestUser;
                }
                else
                {
                    MessageBox.Show("Error! Staff user does not have any repairs");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Error! User no longer on MongoDb database");
                return;
            }
        }

        private void buttonAddUserMongo_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUserInterface display = new AddUserInterface(loginUser, "MongoDB");
            display.ShowDialog();
            this.Close();
        }
    }
}
