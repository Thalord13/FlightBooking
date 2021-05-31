using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightBooking
{
    public partial class confirmation : Form
    {

        string MyConnection2 = "server=localhost;database=airlines;uid=root;pwd=;";
        BookObject book;

        public confirmation()
        {
            InitializeComponent();
            fromLabel.Text = BookObject.FlightDestinationFrom.ToString();
            toLabel.Text = BookObject.FlightDestinationTo.ToString();
            scheduleLabel.Text = BookObject.FlightSchedule.ToString();
            fareLabel.Text = BookObject.Fare.ToString();
            seatLabel.Text = BookObject.FlightSeat.ToString();
            //.Text= BookObject.Firstname
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            try
            {
               
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into flightbook(FlightSeat,FlightSchedule,FlightDestinationFrom,FlightDestinationTo,Fare) values('" + BookObject.FlightSeat + "','" + BookObject.FlightSchedule + "','" + BookObject.FlightDestinationFrom + "','" + BookObject.FlightDestinationTo + "','" + BookObject.Fare + "');";
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
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
