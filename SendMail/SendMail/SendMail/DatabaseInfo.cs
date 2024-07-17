using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SendMail
{
    #region database connection sentence
    internal class DatabaseInfo
    {
        internal string ConnectionString = "Data Source=SERVER NAME ;Initial Catalog=DATABASE NAME;Integrated Security=True;";
        //Defines the connection string used to connect to a database. This connection string contains various information that specifies how to make a database connection.
    }
    #endregion

    #region database operations
    internal class Connection : DatabaseInfo
    {
        private SqlConnection conn;

        public void Connect()
        {
            /*
             This piece of code is used to attempt to connect to and open a SQL Server database. 
             If an error occurs during the connection opening process, the error message is captured and printed to the console.
             
             */
            conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                Console.WriteLine("Database connection opened successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while connecting to the database: " + ex.Message);
            }
        }

        public void Close()
        {
            /*
             This piece of code checks if a database connection is open, and if it is, closes the connection.
             It then prints a message to the console indicating that the connection was closed successfully.
             */
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                Console.WriteLine("Database connection closed successfully.");
            }
        }

        public void InsertMailInfo(string senderMail, string password, string buyerMail, string message)
        {
            /*
             This piece of code is used to insert data with parameters into a SQL Server database.
            Executes the SQL INSERT command along with the parameters using SqlCommand and parameters. 
            This catches any possible errors during the process and prints them to the console.
             
             
             
             */
            string query = "INSERT INTO MailInfo (SenderMail, Password, BuyerMail, Message) VALUES (@SenderMail, @Password, @BuyerMail, @Message)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@SenderMail", senderMail);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@BuyerMail", buyerMail);
                cmd.Parameters.AddWithValue("@Message", message);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("Rows inserted: " + rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while inserting data: " + ex.Message);
                }
            }
        }

        public DataTable GetMailInfo()
        {
            /*
             This piece of code is used to read data from a SQL Server database.
            SQL SELECT command is executed using SqlCommand and SqlDataAdapter and the result of this command is filled into the DataTable object.
            The dataTable object is then returned, allowing the data retrieved from the database to be processed.
             
             
             */
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM MailInfo";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while retrieving data: " + ex.Message);
                }
            }

            return dataTable;
        }

        public static void DeleteSelectedRow(DataGridView dataGridView)
        {
            /*
             This piece of code is used to remove a selected row from a DataGridView control.
            The number of selected rows is controlled with the dataGridView.SelectedRows.Count property.
            If at least one row is selected, the first selected row (dataGridView.SelectedRows[0]) is removed with the dataGridView.Rows.Remove(selectedRow) method.
            If no rows are selected, a warning is displayed to the user.
             
             
             
             */
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Remove row from DataGridView
                dataGridView.Rows.Remove(selectedRow);
            }
            else
            {

                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
    #endregion
}
