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
    public partial class ucCustomer : UserControl
    {

        private static ucCustomer _instance;
        public static ucCustomer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucCustomer();
                return _instance;
            }
        }

        public ucCustomer()
        {
            InitializeComponent();
            GetDataToGridview();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCusId.Text == "")
            {
                MessageBox.Show("Enter or Select ID for the operation");
                txtCusId.Focus();
            }
            else if (txtCusName.Text == "")
            {
                MessageBox.Show("Enter or Select Name for the operation");
                txtCusName.Focus();
            }
            else if (txtCusTel.Text == "")
            {
                MessageBox.Show("Enter or Select Tel Number for the operation");
                txtCusTel.Focus();
            }
            else if (txtCusEmail.Text == "")
            {
                MessageBox.Show("Enter or Select Email for the operation");
                txtCusEmail.Focus();
            }
            else
            {
                try
                {
                    cls_db_Connection.open_connection();
                    string myCommand = "INSERT INTO `customer` (`customer_id`, `customer_name`, `customer_tel`, `customer_email`) VALUES ('" + txtCusId.Text + "', '" + txtCusName.Text + "', '" + txtCusTel.Text + "', '" + txtCusEmail.Text + "');";
                    MySqlCommand cmd = new MySqlCommand(myCommand, cls_db_Connection.con);
                    cmd.ExecuteNonQuery();
                    GetDataToGridview();
                    MessageBox.Show("Customer Added", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Banquet Hall Reservation System", MessageBoxButtons.OK);
                }
                finally
                {
                    cls_db_Connection.close_connection();
                    clearTextBoxes();
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
                resultscommand = new MySqlCommand("SELECT * FROM `db_banquethallsreservationsystem`.`customer`", cls_db_Connection.con);
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
        private void clearTextBoxes()
        {
            txtCusId.Clear();
            txtCusName.Clear();
            txtCusTel.Clear();
            txtCusEmail.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCusId.Text == "")
            {
                MessageBox.Show("Enter or Select ID for the operation");
                txtCusId.Focus();
            }
            else if (txtCusName.Text == "")
            {
                MessageBox.Show("Enter or Select Name for the operation");
                txtCusName.Focus();
            }
            else if (txtCusTel.Text == "")
            {
                MessageBox.Show("Enter or Select Tel Number for the operation");
                txtCusTel.Focus();
            }
            else if (txtCusEmail.Text == "")
            {
                MessageBox.Show("Enter or Select Email for the operation");
                txtCusEmail.Focus();
            }
            else
            {
                try
                {
                    lblWarning.Text = "**Remember that, Customer ID can not change ";
                    cls_db_Connection.open_connection();
                    string myCommand = "UPDATE `customer` SET `customer_name` = '" + txtCusName.Text + "', `customer_tel` = '" + txtCusTel.Text + "', `customer_email` = '" + txtCusEmail.Text + "' WHERE `customer`.`customer_id` = '" + txtCusId.Text + "'";
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
                    clearTextBoxes();
                }

                //Need to add the button which is if update a record then reservation must be change to last position / waiting list


            }
        }

        private void grdCusView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int SelectedRow;
                SelectedRow = e.RowIndex;
                DataGridViewRow row = grdCusView.Rows[SelectedRow];
                txtCusId.Text = row.Cells[0].Value.ToString();
                txtCusName.Text = row.Cells[1].Value.ToString();
                txtCusTel.Text = row.Cells[2].Value.ToString();
                txtCusEmail.Text = row.Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error !", "Banquet Hall Reservation System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCusId.Text == "")
            {
                MessageBox.Show("Enter or Select ID for the operation");
                txtCusId.Focus();
            }
            else if (txtCusName.Text == "")
            {
                MessageBox.Show("Enter or Select Name for the operation");
                txtCusName.Focus();
            }
            else if (txtCusTel.Text == "")
            {
                MessageBox.Show("Enter or Select Tel Number for the operation");
                txtCusTel.Focus();
            }
            else if (txtCusEmail.Text == "")
            {
                MessageBox.Show("Enter or Select Email for the operation");
                txtCusEmail.Focus();
            }
            else if (MessageBox.Show("Do you want to delete record?", "Delete record !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    cls_db_Connection.open_connection();
                    string myCommand = "DELETE FROM `customer` WHERE `customer`.`customer_id` = '"+txtCusId.Text+"'";
                    MySqlCommand cmd = new MySqlCommand(myCommand, cls_db_Connection.con);
                    cmd.ExecuteNonQuery();
                    GetDataToGridview();
                    MessageBox.Show("Record Deleted", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    GetDataToGridview();

                }
                catch
                {
                    MessageBox.Show("Error !", "Banquet Hall Reservation System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cls_db_Connection.close_connection();
                    clearTextBoxes();
                }
            }
            }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }
    }
}

