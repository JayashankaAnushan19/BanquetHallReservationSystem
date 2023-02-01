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
    public partial class ucHotelRegistration : UserControl
    {
        private static ucHotelRegistration _instance;
        public static ucHotelRegistration Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucHotelRegistration();
                return _instance;
            }
        }
        public ucHotelRegistration()
        {
            InitializeComponent();
            GetDataToGridview();
        }

        private void GetDataToGridview()
        {
            try
            {
                MySqlCommand resultscommand = null;
                MySqlDataAdapter mysqladp = new MySqlDataAdapter();
                DataTable resultstable = new DataTable();
                resultscommand = new MySqlCommand("SELECT * FROM `db_banquethallsreservationsystem`.`hotel`", cls_db_Connection.con);
                mysqladp.SelectCommand = resultscommand;
                mysqladp.Fill(resultstable);
                grdHotelView.DataSource = resultstable;
                grdHotelView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Banquet Hall Reservation System", MessageBoxButtons.OK);
            }
        }

        private void grdHotelView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int SelectedRow;
                SelectedRow = e.RowIndex;
                DataGridViewRow row = grdHotelView.Rows[SelectedRow];
                txtHotelId.Text = row.Cells[0].Value.ToString();
                txtHotelName.Text = row.Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error !", "Banquet Hall Reservation System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtHotelName.Text == "")
            {
                MessageBox.Show("Enter or Select Hotel for the operation");
                txtHotelName.Focus();
            }
            else
            {
                try
                {
                    cls_db_Connection.open_connection();
                    string myCommand = "INSERT INTO `hotel` (`hotel_name`) VALUES ('" + txtHotelName.Text + "');";
                    MySqlCommand cmd = new MySqlCommand(myCommand, cls_db_Connection.con);
                    cmd.ExecuteNonQuery();
                    GetDataToGridview();
                    MessageBox.Show("Hotel Added", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Banquet Hall Reservation System", MessageBoxButtons.OK);
                }
                finally
                {
                    cls_db_Connection.close_connection();
                    txtHotelId.Clear();
                    txtHotelName.Clear();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtHotelName.Text == "")
            {
                MessageBox.Show("Enter or Select Hotel for the operation");
                txtHotelName.Focus();
            }
            else
            {
                try
                {
                    cls_db_Connection.open_connection();
                    string myCommand = "UPDATE `hotel` SET `hotel_name` = '" + txtHotelName.Text + "' WHERE `hotel`.`hotel_id` = '" + txtHotelId.Text + "';";
                    MySqlCommand cmd = new MySqlCommand(myCommand, cls_db_Connection.con);
                    cmd.ExecuteNonQuery();
                    GetDataToGridview();
                    MessageBox.Show("Customer Details Updated", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Banquet Hall Reservation System", MessageBoxButtons.OK);
                }
                finally
                {
                    cls_db_Connection.close_connection();
                    txtHotelId.Clear();
                    txtHotelName.Clear();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotelId.Clear();
            txtHotelName.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtHotelName.Text == "")
            {
                MessageBox.Show("Enter or Select Hotel for the operation");
                txtHotelName.Focus();
            }
            else if (txtHotelId.Text == "")
            {
                MessageBox.Show("Invalid Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHotelName.Focus();
            }
            else if (MessageBox.Show("Do you want to delete record?", "Delete record !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    //DELETE FROM `customer` WHERE `customer`.`customer_id` = 'cascas';
                    cls_db_Connection.open_connection();
                    string myCommand = "DELETE FROM `hotel` WHERE `hotel`.`hotel_id` = '" + txtHotelId.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(myCommand, cls_db_Connection.con);
                    cmd.ExecuteNonQuery();
                    GetDataToGridview();
                    MessageBox.Show("Record Deleted", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    GetDataToGridview();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Banquet Hall Reservation System", MessageBoxButtons.OK);
                }
                finally
                {
                    cls_db_Connection.close_connection();
                    txtHotelId.Clear();
                    txtHotelName.Clear();
                }
            }
        }
    }
}
