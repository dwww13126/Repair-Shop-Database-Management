using System;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace COMPX323_APP
{
    class SQL
    {
        //generates the connection to the database       
        //Make sure that in the Database connection you put your Database connection here:
        static string oradb = "<SQLDBConString>";
        public static OracleConnection con;
        public static OracleCommand cmd;
        public static OracleDataReader dr;


        public static void initialize()
        {
            con = new OracleConnection(oradb);
            con.Open();
            cmd = new OracleCommand();
            cmd.Connection = con;
            Console.WriteLine("Database initialized");
        }

        public static void end()
        {
            dr.Dispose();
            con.Dispose();
        }

        /// <summary>
        /// This excecutres the query, used mainly for 
        /// insert/delete/update statements etc. where we don't need
        /// to read from what we are doing.
        /// </summary>
        /// <param name="query"></param>
        public static void executeQuery(string query)
        {
            //try catch to catch any unforseen errors gracefully
            try
            {
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        /// <summary>
        /// Generates an SQL query based on the input
        /// query e.g. "SELECT * FROM staff"
        /// </summary>
        /// <param name="query"></param>
        public static void selectQuery(string query)
        {
            try
            {
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        /// <summary>
        /// Prints out the ID  based on the query givin into a combo box
        /// </summary>
        /// <param name="comboBox">A control to be used to write existing names to</param>
        /// <param name="query">An SQL query to generate from</param>
        public static void editComboBoxItems(ComboBox comboBox, string query)
        {
            bool clear = true;

            //gets data from database
            SQL.selectQuery(query);
            //Check that there is something to write brah
            if (SQL.dr.HasRows)
            {
                while (SQL.dr.Read())
                {
                    if (comboBox.Text == SQL.dr[0].ToString())
                    {
                        clear = false;
                    }
                }
            }

            //gets data from database
            SQL.selectQuery(query);
            //if nothing in the comboBox then we need to clear it
            if (clear)
            {
                comboBox.Text = "";
                comboBox.Items.Clear();

            }

            // this will print whatever is in the database to the combobox
            if (SQL.dr.HasRows)
            {
                while (SQL.dr.Read())
                {
                    comboBox.Items.Add(SQL.dr[0].ToString());
                }
            }
        }
    }
}
