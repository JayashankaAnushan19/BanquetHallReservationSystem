using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BanquetHallReservationSystem
{
    public partial class ucReservation : UserControl
    {
        private static ucReservation _instance;
        public static ucReservation Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucReservation();
                return _instance;
            }
        }
        public ucReservation()
        {
            InitializeComponent();
            removeDataFromComboBox();
            loadDataToComboBox();
            GetDataToGridview();
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                cls_db_Connection.open_connection();
                string CCN = "SELECT * FROM `customer`";
                MySqlDataAdapter da = new MySqlDataAdapter(CCN, cls_db_Connection.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow[] returnrow = ds.Tables[0].Select("customer_id='" + txtCusId.Text + "'");  //Get data from user input for check
                DataRow dr = returnrow[0];

                if (txtCusId.Text == (dr["customer_id"].ToString()))  //check validation
                {
                    lblWarning.Text = "Customer:- "+dr["customer_name"].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Customer ID !!!", "Invalid...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCusId.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error , Wrong Customer ID... " + ex.Message, "Banquet Hall Reservation System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCusId.Focus();
            }
            finally
            {
                cls_db_Connection.close_connection();
            }

            
        }
        public void loadDataToComboBox()
        {
            try
            {
                string query = "SELECT `hall_location` FROM `hall`";
                MySqlCommand Mycom = new MySqlCommand(query, cls_db_Connection.con);
                MySqlDataReader Myreader;
                cls_db_Connection.open_connection();
                Myreader = Mycom.ExecuteReader();
                if (Myreader.HasRows)
                {
                    while (Myreader.Read())
                    {
                        string HallLocations = Myreader.GetString(0).ToString();
                        comboBox1.Items.Add(HallLocations);
                    }
                }

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
        public void removeDataFromComboBox()
        {
            try
            {
                string query = "SELECT `hall_location` FROM `hall`";
                MySqlCommand Mycom = new MySqlCommand(query, cls_db_Connection.con);
                MySqlDataReader Myreader;
                cls_db_Connection.open_connection();
                Myreader = Mycom.ExecuteReader();
                if (Myreader.HasRows)
                {
                    while (Myreader.Read())
                    {
                        string HallLocations = Myreader.GetString(0).ToString();
                        comboBox1.Items.Remove(HallLocations);
                    }
                }

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCusId.Clear();
            lblWarning.Text = "* Select Customer ID *";
            comboBox1.Text = "";
            txtNumberOfGuests.Clear();
            datetimeText.ResetText();
            GetDataToGridview();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCusId.Text == "")
            {
                MessageBox.Show("Enter or Select Customer ID for the operation");
                txtCusId.Focus();
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Enter or Select Location for the operation");
                comboBox1.Focus();
            }
            else
            {
                try
                {
                    specialDeleteReservationAndUpdateHall();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Banquet Hall Reservation System", MessageBoxButtons.OK);
                }
                finally
                {
                    cls_db_Connection.close_connection();
                    txtCusId.Clear();
                    lblWarning.Text = "* Select Customer ID *";
                    comboBox1.Text = "";
                    txtNumberOfGuests.Clear();
                    datetimeText.ResetText();
                    GetDataToGridview();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCusId.Text == "")
            {
                MessageBox.Show("Enter or Select Customer ID for the operation");
                txtCusId.Focus();
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Enter or Select Hall Location for the operation");
                comboBox1.Focus();
            }
            else if (txtNumberOfGuests.Text == "")
            {
                MessageBox.Show("Enter or Select Number of guests for the operation");
                txtNumberOfGuests.Focus();
            }
            else if (datetimeText.Text == "")
            {
                MessageBox.Show("Enter or Select Reservation Date for the operation");
                datetimeText.Focus();
            }
            else if ((MessageBox.Show("Are you sure want to Update record? It may change reservation order and current reservation", "Update Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK))
            {
                try
                {
                    specialDeleteReservationAndAddReservation();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Banquet Hall Reservation System", MessageBoxButtons.OK);
                }
                finally
                {
                    cls_db_Connection.close_connection();
                    txtCusId.Clear();
                    lblWarning.Text = "* Select Customer ID *";
                    comboBox1.Text = "";
                    txtNumberOfGuests.Clear();
                    datetimeText.ResetText();
                    GetDataToGridview();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCusId.Text == "")
            {
                MessageBox.Show("Enter or Select Customer ID for the operation");
                txtCusId.Focus();
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Enter or Select Hall Location for the operation");
                comboBox1.Focus();
            }
            else if (txtNumberOfGuests.Text == "")
            {
                MessageBox.Show("Enter or Select Number of guests for the operation");
                txtNumberOfGuests.Focus();
            }
            else if (datetimeText.Text == "")
            {
                MessageBox.Show("Enter or Select Reservation Date for the operation");
                datetimeText.Focus();
            }
            else
            {
                try
                {
                    cls_db_Connection.open_connection();
                    string myCommand = "INSERT INTO `reservation`(`reservation_location`, `reservation_status`, `reservation_numberofguest`, `reservation_date`, `customer_id`) VALUES ('"+comboBox1.Text+ "','Pending','" + txtNumberOfGuests.Text + "','" + datetimeText.Text + "','" + txtCusId.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(myCommand, cls_db_Connection.con);
                    cmd.ExecuteNonQuery();
                    GetDataToGridview();
                    
                    grdCusView.ClearSelection(); //For Clear Selection of the gdrid view

                    int nRoeIndex = grdCusView.Rows.Count - 1; //Count rows then select index
                    int nColumnIndex = 3;

                    grdCusView.Rows[nRoeIndex].Selected = true;
                    grdCusView.Rows[nRoeIndex].Cells[nColumnIndex].Selected = true;

                    DataGridViewRow row = grdCusView.Rows[nRoeIndex];

                    string ResIDShowMsg = row.Cells[0].Value.ToString();
                    string ResCusIDShowMsg = row.Cells[5].Value.ToString();
                    string ResLocationShowMsg = row.Cells[1].Value.ToString();
                    string ResNumOfGuesShowMsg = row.Cells[3].Value.ToString();
                    string ResStatusShowMsg = row.Cells[2].Value.ToString();


                    grdCusView.FirstDisplayedScrollingRowIndex = nRoeIndex;

                    MessageBox.Show("Reservation Success ... \n Your Reservation ID is	= " + "'" + ResIDShowMsg + "' \n Customer ID is		= " + "'" + ResCusIDShowMsg + "' \n Customer Reserved Location is= " + "'" + ResLocationShowMsg + "' \n Number of guests 	= " + "'" + ResNumOfGuesShowMsg + "' \n Reservation status	= " + "'" + ResStatusShowMsg + "'", "Reservation Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Banquet Hall Reservation System", MessageBoxButtons.OK);
                }
                finally
                {
                    cls_db_Connection.close_connection();
                    txtCusId.Clear();
                    lblWarning.Text = "* Select Customer ID *";
                    comboBox1.Text = "";
                    txtNumberOfGuests.Clear();
                    datetimeText.ResetText();
                }
            }
        }
        private void GetDataToGridview()
        {
            try
            {
                MySqlCommand resultscommand = null;
                MySqlDataAdapter mysqladp = new MySqlDataAdapter();
                DataTable resultstable = new DataTable();
                resultscommand = new MySqlCommand("SELECT `reservation_id`, `reservation_location`, `reservation_status`, `reservation_numberofguest`, `reservation_date`, `customer_id`, `hotel_id` FROM `db_banquethallsreservationsystem`.`reservation`", cls_db_Connection.con);
                mysqladp.SelectCommand = resultscommand;
                mysqladp.Fill(resultstable);
                grdCusView.DataSource = resultstable;
                grdCusView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Banquet Hall Reservation System", MessageBoxButtons.OK);
            }
        }

        private void specialDeleteReservationAndAddReservation()
        {
            cls_db_Connection.open_connection();
            string myCommand1 = "DELETE FROM `reservation` WHERE `reservation`.`reservation_id` = '"+lblResId.Text+"'";
            MySqlCommand cmd1 = new MySqlCommand(myCommand1, cls_db_Connection.con);
            cmd1.ExecuteNonQuery();
            string myCommand = "INSERT INTO `reservation`(`reservation_location`, `reservation_status`, `reservation_numberofguest`, `reservation_date`, `customer_id`) VALUES ('" + comboBox1.Text + "','Pending','" + txtNumberOfGuests.Text + "','" + datetimeText.Text + "','" + txtCusId.Text + "')";
            MySqlCommand cmd = new MySqlCommand(myCommand, cls_db_Connection.con);
            cmd.ExecuteNonQuery();
            txtCusId.Clear();
            lblWarning.Text = "* Select Customer ID *";
            comboBox1.Text = "";
            txtNumberOfGuests.Clear();
            datetimeText.ResetText();
            GetDataToGridview();
            cls_db_Connection.close_connection();
            MessageBox.Show("Reservation Details Updated", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void specialDeleteReservationAndUpdateHall()
        {
            cls_db_Connection.open_connection();
            
            specialDeleteReservationThenUpdateHall();

            string myCommand1 = "DELETE FROM `reservation` WHERE `reservation`.`reservation_id` = '" + lblResId.Text + "'";
            MySqlCommand cmd1 = new MySqlCommand(myCommand1, cls_db_Connection.con);
            cmd1.ExecuteNonQuery();

            txtCusId.Clear();
            lblWarning.Text = "* Select Customer ID *";
            comboBox1.Text = "";
            txtNumberOfGuests.Clear();
            datetimeText.ResetText();
            GetDataToGridview();
            cls_db_Connection.close_connection();
            MessageBox.Show("Reservation Details Deleted", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void specialDeleteReservationThenUpdateHall()
        {
            try
            {
                string myCommand = "UPDATE `hall` SET `hall_status`='Pending' WHERE `hall`.`hall_id` = '" + lblResCusHotelID.Text + "'";
                MySqlCommand cmd = new MySqlCommand(myCommand, cls_db_Connection.con);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            removeDataFromComboBox();
            loadDataToComboBox();
            GetDataToGridview();
        }

        private void grdCusView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int SelectedRow;
                SelectedRow = e.RowIndex;
                DataGridViewRow row = grdCusView.Rows[SelectedRow];

                lblResId.Text = row.Cells[0].Value.ToString();
                txtCusId.Text = row.Cells[5].Value.ToString();
                comboBox1.Text = row.Cells[1].Value.ToString();
                txtNumberOfGuests.Text = row.Cells[3].Value.ToString();
                datetimeText.Text = row.Cells[4].Value.ToString();
                lblResCusHotelID.Text = row.Cells[6].Value.ToString();
                try
                {
                    cls_db_Connection.open_connection();
                    string CCN = "SELECT * FROM `customer`";
                    MySqlDataAdapter da = new MySqlDataAdapter(CCN, cls_db_Connection.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataRow[] returnrow = ds.Tables[0].Select("customer_id='" + txtCusId.Text + "'");  //Get data from user input for check
                    DataRow dr = returnrow[0];

                    if (txtCusId.Text == (dr["customer_id"].ToString()))  //check validation
                    {
                        lblWarning.Text = "Customer :- " + dr["customer_name"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Customer ID !!!", "Invalid...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCusId.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error , Wrong Customer ID... " + ex.Message, "Banquet Hall Reservation System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCusId.Focus();
                }
                finally
                {
                    cls_db_Connection.close_connection();
                }

            }
            catch
            {
                MessageBox.Show("Error !", "Banquet Hall Reservation System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datetimeText.Text = DateTime.Now.ToString("yyyy-MMM-dd");
        }

        private void datetimeText_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
