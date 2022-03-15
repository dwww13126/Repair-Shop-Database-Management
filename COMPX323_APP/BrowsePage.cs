using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPX323_APP
{
    public partial class BrowsePage : Form
    {
        /// <summary>
        /// //This BrowsePage method executes upon loading of the form
        /// </summary>
        public BrowsePage()
        {
            InitializeComponent();
            //*YOUR CODE HERE*

        }

        /// <summary>
        /// Will search through the database based on combobox data
        /// will return a list of data displayed on the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //variables
            string username = "", socialMedia = "", socialMediaID = "",
                query = "", sessionID = "";
            int sessionTime = 0;

            //Check that the combo boxes hold data first
            if (comboBoxUsername.SelectedItem == null
                || comboBoxSocialMedia.SelectedItem == null)
            {
                //One of the boxes do not have a selected item
                MessageBox.Show("Please make sure that you select a Username and a SocialMedia");
                return;
            }

            //(1)
            //give the username and socialMedia variables proper data

            //*YOUR CODE HERE*


            //if socialMediaID is blank then there is no data in the database matching that social media
            //This is just an extra check, not really needed because users are restricted to choose a select few options,
            //But thought it was good for you to see how you could error check it.
            if ("".Equals(socialMediaID))
            {
                //invalid social media name
                MessageBox.Show("Sorry, social media does not exist in the database.  Please choose an appropriate one!");
                return;
            }

            //(2)
            //Query to get the data we want from a table using username and ID

            //*YOUR CODE HERE*

            //clear the listbox previous data
            listBoxDisplay.Items.Clear();

            try
            {
                //(3)
                //Similar to the login page query, we will check that data has been returned
                //Then loop through each row, printing the data to the list box

                //*YOUR CODE HERE*
            }
            catch
            {
                //If an error happens here, it means error in locating data
                MessageBox.Show("Error in querying database.  Please check that the database is connected.");
            }

        }

        /// <summary>
        /// Takes us back to the login page when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //You should have seen this from the register page, same code to switch forms.
            Hide();
            LoginPage login = new LoginPage();
            login.ShowDialog();
            Close();
        }

        /// <summary>
        /// Gets the social media id based on the social media name
        /// </summary>
        /// <param name="socialMedia">The name of the social media from combo box</param>
        /// <returns>The ID of the social media from database, blank string returned if not in database</returns>
        private string getMediaID(string socialMedia)
        {
            //string for return variable
            string SocMediaID = "";
            //query getting the ID based on the social media name
            SQL.selectQuery("SELECT SocMediaID FROM SocialMedia WHERE SocialMediaName LIKE \'" + socialMedia + "\'");
            //if there exists an ID in database, and its not blank then make socMedia ID = something
            if (SQL.read.HasRows)
            {
                //read from the table to store in its array
                SQL.read.Read();
                //if the data read is not blank then
                if (!("".Equals(SQL.read[0].ToString())))
                {
                    //make the ID variable equal the database value
                    SocMediaID = SQL.read[0].ToString();
                }
            }
            //else it will leave socMediaID as a blank string and return that
            return SocMediaID;
        }

    }
}
