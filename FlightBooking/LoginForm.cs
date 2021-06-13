using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightBooking
{
    public partial class LoginForm : Form
    {
        string MyConnection2 = "server=localhost;database=airlines;uid=root;pwd=;";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Log_in.Username = txtbx_username.Text;
            Log_in.Password = txtbx_password.Text;

            try
            {

            }
            catch(Exception ex)
            {
                string Query = "select username,password from flightuser where = '"+ Log_in.Username + "','" + Log_in.Password + "','" ;
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Log-in Successfully!");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
                this.Close();
            }
        }
    }
}
