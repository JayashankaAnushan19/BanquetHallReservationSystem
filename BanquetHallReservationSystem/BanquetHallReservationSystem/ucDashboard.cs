using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BanquetHallReservationSystem
{
    public partial class ucDashboard : UserControl
    {
        private static ucDashboard _instance;
        public static ucDashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDashboard();
                return _instance;
            }
        }

        public ucDashboard()
        {
            InitializeComponent();
            countReservations();
            countCustomers();
            countHalls();
            countHotels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countReservations();
            countCustomers();
            countHalls();
            countHotels();
        }

        public void countReservations()
        {
            try
            {
                cls_db_Connection.open_connection();
                string myCommand = "SELECT COUNT(*) FROM `reservation`";
                MySqlCommand cmd = new MySqlCommand(myCommand, cls_db_Connection.con);

                lblReservations.Text = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cls_db_Connection.close_connection();
            }
        }
        public void countCustomers()
        {
            try
            {
                cls_db_Connection.open_connection();
                string myCommand = "SELECT COUNT(*) FROM `customer`";
                MySqlCommand cmd = new MySqlCommand(myCommand, cls_db_Connection.con);

                lblCustomers.Text = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cls_db_Connection.close_connection();
            }
        }
        public void countHotels()
        {
            try
            {
                cls_db_Connection.open_connection();
                string myCommand = "SELECT COUNT(*) FROM `hotel`";
                MySqlCommand cmd = new MySqlCommand(myCommand, cls_db_Connection.con);

                lblHotels.Text = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cls_db_Connection.close_connection();
            }
        }
        public void countHalls()
        {
            try
            {
                cls_db_Connection.open_connection();
                string myCommand = "SELECT COUNT(*) FROM `hall`";
                MySqlCommand cmd = new MySqlCommand(myCommand, cls_db_Connection.con);

                lblHalls.Text = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cls_db_Connection.close_connection();
            }
        }

        private void lblHalls_Click(object sender, EventArgs e)
        {

        }
    }
}
