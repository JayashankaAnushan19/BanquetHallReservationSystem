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
    public partial class ucHallRegistration : UserControl
    {
        private static ucHallRegistration _instance;
        public static ucHallRegistration Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucHallRegistration();
                return _instance;
            }
        }
        public ucHallRegistration()
        {
            InitializeComponent();
            GetDataToGridview();
            removeDataFromComboBox();
            loadDataToComboBox();
        }
        public void loadDataToComboBox()
        {
            try
            {
                string query = "SELECT `hotel_name` FROM `hotel`";
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
                      //  comboBox1.Items.Remove(HallLocations);
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
                string query = "SELECT `hotel_name` FROM `hotel`";
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

        private void GetDataToGridview()
        {
            try
            {
                MySqlCommand resultscommand = null;
                MySqlDataAdapter mysqladp = new MySqlDataAdapter();
                DataTable resultstable = new DataTable();
                resultscommand = new MySqlCommand("SELECT * FROM `db_banquethallsreservationsystem`.`hall`", cls_db_Connection.con);
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

        private void grdCusView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int SelectedRow;
                SelectedRow = e.RowIndex;
                DataGridViewRow row = grdCusView.Rows[SelectedRow];
                txtHallName.Text = row.Cells[1].Value.ToString();
                txtHallLocation.Text = row.Cells[2].Value.ToString();
                txtNumberOfGuests.Text = row.Cells[3].Value.ToString();
                comboBox1.Text = row.Cells[5].Value.ToString();
                lblHallId.Text = row.Cells[0].Value.ToString();
                lblStatus.Text = row.Cells[4].Value.ToString();

                
                
            }
            catch
            {
                MessageBox.Show("Error !", "Banquet Hall Reservation System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHallName.Clear();
            txtNumberOfGuests.Clear();
            comboBox1.Text = "";
            txtHallLocation.Clear();
            lblHallId.Text = "";
            lblStatus.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtHallName.Text == "")
            {
                MessageBox.Show("Enter or Select Hall Name for the operation");
                txtHallName.Focus();
            }
            else if (txtNumberOfGuests.Text == "")
            {
                MessageBox.Show("Enter or Select Number of guests of the hall for the operation");
                txtNumberOfGuests.Focus();
            }
  /*          else if (!(txtNumberOfGuests.Text == int value))
            {
                MessageBox.Show("Wrong input. Enter numerical value");
                txtNumberOfGuests.Focus();
            } */
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Enter or Select Hotel Name for the operation");
                comboBox1.Focus();
            }
            else if (txtHallLocation.Text == "")
            {
                MessageBox.Show("Enter or Select Hall Location for the operation");
                txtHallLocation.Focus();
            }
            else
            {
                try
                {
                    cls_db_Connection.open_connection();
                    string myCommand = "INSERT INTO `hall`(`hall_name`, `hall_location`, `hall_numberofguest`, `hall_status`, `hotel_name`) VALUES ('"+txtHallName.Text+ "','" + txtHallLocation.Text + "','" + txtNumberOfGuests.Text + "','Pending','" + comboBox1.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(myCommand, cls_db_Connection.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hall Added", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetDataToGridview();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Banquet Hall Reservation System", MessageBoxButtons.OK);
                }
                finally
                {
                    cls_db_Connection.close_connection();
                    txtHallName.Clear();
                    txtNumberOfGuests.Clear();
                    comboBox1.Text = "";
                    txtHallLocation.Clear();
                    lblHallId.Text = "";
                    lblStatus.Text = "";
                    GetDataToGridview();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtHallName.Text == "")
            {
                MessageBox.Show("Enter or Select Hall Name for the operation");
                txtHallName.Focus();
            }
            else if (txtNumberOfGuests.Text == "")
            {
                MessageBox.Show("Enter or Select Number of guests of the hall for the operation");
                txtNumberOfGuests.Focus();
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Enter or Select Hotel Name for the operation");
                comboBox1.Focus();
            }
            else if (txtHallLocation.Text == "")
            {
                MessageBox.Show("Enter or Select Hall Location for the operation");
                txtHallLocation.Focus();
            }
            else if ((MessageBox.Show("Are you sure want to update record?","Update Record",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation)==DialogResult.OK))
            {
                try
                {
                    specialUpdateHallAndUpdateReservation();
                    GetDataToGridview();
                    MessageBox.Show("Hall Details Updated", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Banquet Hall Reservation System", MessageBoxButtons.OK);
                }
                finally
                {
                    cls_db_Connection.close_connection();
                    txtHallName.Clear();
                    txtNumberOfGuests.Clear();
                    comboBox1.Text = "";
                    txtHallLocation.Clear();
                    lblHallId.Text = "";
                    lblStatus.Text = "";
                }
            }
            else
            {

            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "Checked")
            {
                if(MessageBox.Show("This is customer checked hall and already customer informed hall. Are you sure do you want to delete this hall record?","Already cheched record",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
                {
                    specialDeleteHallAndUpdateHall();
                }
                else
                {
                    MessageBox.Show("Enter or Select Another Hall for the operation");
                    comboBox1.Text = "";
                    txtHallLocation.Clear();
                    lblHallId.Text = "";
                }
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Enter or Select Hotel Name for the operation");
                comboBox1.Focus();
            }
            else if (txtHallLocation.Text == "")
            {
                MessageBox.Show("Enter or Select Hall Location for the operation");
                txtHallLocation.Focus();
            }
            else if(MessageBox.Show("Do you want to delete record?", "Delete record !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {

                    specialDeleteHallAndUpdateHall();

                }
                catch
                {
                    MessageBox.Show("Error !", "Banquet Hall Reservation System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cls_db_Connection.close_connection();
                    txtHallName.Clear();
                    txtNumberOfGuests.Clear();
                    comboBox1.Text = "";
                    txtHallLocation.Clear();
                    lblHallId.Text = "";
                    lblStatus.Text = "";
                }
            }
            else
            {

            }

        }
        public void specialUpdateHallAndUpdateReservation()
        {
            cls_db_Connection.open_connection();
            string myCommand1 = "UPDATE `hall` SET `hall_name`='" + txtHallName.Text + "',`hall_location`='" + txtHallLocation.Text + "',`hall_numberofguest`='" + txtNumberOfGuests.Text + "',`hall_status`='Pending',`hotel_name`='" + comboBox1.Text + "' WHERE `hall`.`hall_id` = '" + lblHallId.Text + "'";
            MySqlCommand cmd1 = new MySqlCommand(myCommand1, cls_db_Connection.con);
            cmd1.ExecuteNonQuery();
            string myCommand = "UPDATE `reservation` SET `reservation_status` = 'Pending' WHERE `reservation`.`hotel_id` ='" + lblHallId.Text + "';";
            MySqlCommand cmd = new MySqlCommand(myCommand, cls_db_Connection.con);
            cmd.ExecuteNonQuery();
            txtHallName.Clear();
            txtNumberOfGuests.Clear();
            comboBox1.Text = "";
            txtHallLocation.Clear();
            lblHallId.Text = "";
            lblStatus.Text = "";
            cls_db_Connection.close_connection();
        }
        public void specialDeleteHallAndUpdateHall()
        {
            cls_db_Connection.open_connection();
            string myCommand = "DELETE FROM `hall` WHERE `hall`.`hall_id` = '" + lblHallId.Text + "';";
            MySqlCommand cmd = new MySqlCommand(myCommand, cls_db_Connection.con);
            cmd.ExecuteNonQuery();
            string myCommanda = "UPDATE `reservation` SET `reservation_status` = 'Pending' WHERE `reservation`.`hotel_id` ='" + lblHallId.Text + "';";
            MySqlCommand cmda = new MySqlCommand(myCommanda, cls_db_Connection.con);
            cmda.ExecuteNonQuery();
            cls_db_Connection.close_connection();
            MessageBox.Show("Record Deleted", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            GetDataToGridview();
            txtHallName.Clear();
            txtNumberOfGuests.Clear();
            comboBox1.Text = "";
            txtHallLocation.Clear();
            lblHallId.Text = "";
            lblStatus.Text = "";

        }

        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            GetDataToGridview();
            removeDataFromComboBox();
            loadDataToComboBox();

        }

        public void selectionSort (int [] arr)
        {
            //pos_min is short for position of min

            int pos_min, temp;
            for(int i=0; i<arr.Length-1;i++)
            {
                pos_min = i; //set pos_min to the current index of array

                for (int j=i+1; j<arr.Length; j++)
                {
                    if (arr[j]<arr[pos_min])
                    {
                        // pos_min will keeo track of the index that min is in, thus is needed 
                        pos_min = j;

                    }
                }

                // if pos_min no longer ezuals i than a smaller value must have been found, so a swap must be
                
                if (pos_min!=i)
                {
                    temp = arr[i];
                    arr[i] = arr[pos_min];
                    arr[pos_min] = temp;
                }
            }
        } 
        // End of the selection sort

    }
}
