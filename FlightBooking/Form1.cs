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
    public partial class Form1 : Form
    {
        string MyConnection2 = "server=localhost;database=airlines;uid=root;pwd=;";
        string seatNumber = "";

        public Form1()
        {
            InitializeComponent();

            var dateAndTime = DateTime.Now;
            var date = dateAndTime.ToString("M/dd/yyyy");

            try
            {
                //Display query  
                string Query = "select * from flightdestination";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                foreach (DataRow row in dTable.Rows)
                {
                    fromComboBox.Items.Add(row["FlightDestinationTLA"].ToString());
                    toComboBox.Items.Add(row["FlightDestinationTLA"].ToString());
                }
                MyConn2.Close();

            } catch(Exception e)
            {
                MessageBox.Show("There is an error: " + e.Message);
            }

            try
            {
                //Display query  
                // string Query = "select * from flightbook WHERE FlightSchedule ='" + date + "'";
                string Query = "select * from flightbook";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
                MyConn2.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("There is an error: " + e.Message);
            }

            try
            {
                //Display query  
                string Query = "SELECT COUNT(*) AS books FROM flightbook WHERE FlightSchedule ='" + date + "'";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                foreach (DataRow row in dTable.Rows)
                {
                    bookView.Text = row["books"].ToString();
                    string total = row["books"].ToString();
                    int available = 36 - Int32.Parse(total);
                    availableView.Text = available.ToString();
                }
                MyConn2.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("There is an error: " + e.Message);
            }

            viewComboBox.Items.Add("Book");
            viewComboBox.Items.Add("Destination");

        }


        private void BookBtn_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                string theDate = dateTimePicker1.Value.ToShortDateString();
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into flightbook(FlightSeat,FlightSchedule,FlightDestinationFrom,FlightDestinationTo,Fare) values('" + seatNumber + "','" + theDate + "','" + fromComboBox.Text + "','" + toComboBox.Text + "','" + 50 + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Book Successfuly");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } */

            string theDate = dateTimePicker1.Value.ToShortDateString();
            BookObject.FlightSeat = seatNumber;
            BookObject.FlightSchedule = theDate;
            BookObject.FlightDestinationFrom = fromComboBox.Text;
            BookObject.FlightDestinationTo = toComboBox.Text;
            BookObject.Fare = "50";

            /*ja*/
            BookObject.Firstname = first_name;
            BookObject.Lastname = last_name;

            confirmation f2 = new confirmation();
            f2.ShowDialog(); // 

        }

        private void aOneBtn_Click(object sender, EventArgs e)
        {
            seatNumber = "A1";
        }

        private void bOneBtn_Click(object sender, EventArgs e)
        {
            seatNumber = "B1";
        }

        private void cOneBtn_Click(object sender, EventArgs e)
        {
            seatNumber = "C1";
        }

        private void dOneBtn_Click(object sender, EventArgs e)
        {
            seatNumber = "D1";
        }

        private void eOneBtn_Click(object sender, EventArgs e)
        {
            seatNumber = "E1";
        }

        private void fOneBtn_Click(object sender, EventArgs e)
        {
            seatNumber = "F1";
        }

        private void aTwoBtn_Click(object sender, EventArgs e)
        {

        }

        private void bTwoBtn_Click(object sender, EventArgs e)
        {

        }

        private void cTwoBtn_Click(object sender, EventArgs e)
        {

        }

        private void dTwoBtn_Click(object sender, EventArgs e)
        {

        }

        private void eTwoBtn_Click(object sender, EventArgs e)
        {

        }

        private void fTwoBtn_Click(object sender, EventArgs e)
        {

        }

        private void aThreeBtn_Click(object sender, EventArgs e)
        {

        }

        private void bThreeBtn_Click(object sender, EventArgs e)
        {

        }

        private void cThreeBtn_Click(object sender, EventArgs e)
        {

        }

        private void dThreeBtn_Click(object sender, EventArgs e)
        {

        }

        private void fThreeBtn_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("aw");
        }

        private void aFourBtn_Click(object sender, EventArgs e)
        {

        }

        private void bFourBtn_Click(object sender, EventArgs e)
        {

        }

        private void cFourBtn_Click(object sender, EventArgs e)
        {

        }

        private void dFourBtn_Click(object sender, EventArgs e)
        {

        }

        private void eFourBtn_Click(object sender, EventArgs e)
        {

        }

        private void fFourBtn_Click(object sender, EventArgs e)
        {

        }

        private void aFiveBtn_Click(object sender, EventArgs e)
        {

        }

        private void bFiveBtn_Click(object sender, EventArgs e)
        {

        }

        private void cFiveBtn_Click(object sender, EventArgs e)
        {

        }

        private void dFiveBtn_Click(object sender, EventArgs e)
        {

        }

        private void eFiveBtn_Click(object sender, EventArgs e)
        {

        }

        private void fFiveBtn_Click(object sender, EventArgs e)
        {

        }

        private void aSixBtn_Click(object sender, EventArgs e)
        {

        }

        private void bSixBtn_Click(object sender, EventArgs e)
        {

        }

        private void cSixBtn_Click(object sender, EventArgs e)
        {

        }

        private void dSixBtn_Click(object sender, EventArgs e)
        {

        }

        private void eSixBtn_Click(object sender, EventArgs e)
        {

        }

        private void fSixBtn_Click(object sender, EventArgs e)
        {

        }

        private void viewComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "";
            try
            {
                if (viewComboBox.Text.Equals("Book"))
                {
                    Query = "select * from flightbook";
                }
                else
                {
                    Query = "select * from flightdestination";
                }
                //Display query  
               
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void fromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
