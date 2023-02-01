using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanquetHallReservationSystem
{
    public partial class FrmMainWindow : Form
    {
        
        public FrmMainWindow()
        {
            InitializeComponent();
            msg("Welcome !!!");
            showMain();
            timer1.Enabled = true;
            timer1.Start();
        //    showLog();

        }

        public void showLog()
        {
            sidePanel.Enabled = false;
            panelShowWin.Visible = true;
            if (!panelShowWin.Controls.Contains(ucLog.Instance))
            {
                panelShowWin.Controls.Add(ucLog.Instance);
                ucLog.Instance.Dock = DockStyle.Left;
                ucLog.Instance.BringToFront();
            }
            else
                ucLog.Instance.BringToFront();
        }

        public void showMain()
        {
            
            if (!panelShowWin.Controls.Contains(ucCustomer.Instance))
            {
                panelShowWin.Controls.Add(ucMain.Instance);
                ucMain.Instance.Dock = DockStyle.Fill;
                ucMain.Instance.BringToFront();
            }
            else
                ucMain.Instance.BringToFront();
            msg("Welcome !!!");

        }
        public void hideLog()
        {
            sidePanel.Enabled = true;
            panelShowWin.Visible = true;

            sidePanel.Enabled = true;
            panelShowWin.Visible = true;
            if (!panelShowWin.Controls.Contains(ucMain.Instance))
            {
                panelShowWin.Controls.Add(ucMain.Instance);
                ucMain.Instance.Dock = DockStyle.Fill;
                ucMain.Instance.BringToFront();
            }
            else
                ucMain.Instance.BringToFront();
        }

        public void msg(string text)
        {
            lblSelectedWindow.Text = "@ " + text + " @";
        }
        private void FrmMainWindow_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void FrmMainWindow_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void btnCustomerRegistration_Click(object sender, EventArgs e)
        {
            if (!panelShowWin.Controls.Contains(ucCustomer.Instance))
            {
                panelShowWin.Controls.Add(ucCustomer.Instance);
                ucCustomer.Instance.Dock = DockStyle.Fill;
                ucCustomer.Instance.BringToFront();
            }
            else
                ucCustomer.Instance.BringToFront();
            msg("Customer Registration");
        }

        private void btnHotelRegistration_Click(object sender, EventArgs e)
        {
            if (!panelShowWin.Controls.Contains(ucHotelRegistration.Instance))
            {
                panelShowWin.Controls.Add(ucHotelRegistration.Instance);
                ucHotelRegistration.Instance.Dock = DockStyle.Fill;
                ucHotelRegistration.Instance.BringToFront();
            }
            else
                ucHotelRegistration.Instance.BringToFront();
            msg("Hotel Registration");
        }

        private void btnHallRegistration_Click(object sender, EventArgs e)
        {
            if (!panelShowWin.Controls.Contains(ucHallRegistration.Instance))
            {
                panelShowWin.Controls.Add(ucHallRegistration.Instance);
                ucHallRegistration.Instance.Dock = DockStyle.Fill;
                ucHallRegistration.Instance.BringToFront();
            }
            else
                ucHallRegistration.Instance.BringToFront();
            msg("Hall Registration");
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            if (!panelShowWin.Controls.Contains(ucReservation.Instance))
            {
                panelShowWin.Controls.Add(ucReservation.Instance);
                ucReservation.Instance.Dock = DockStyle.Fill;
                ucReservation.Instance.BringToFront();
            }
            else
                ucReservation.Instance.BringToFront();
            msg("Hall Reservation");
        }

        private void btnAdministration_Click(object sender, EventArgs e)
        {
            if (!panelShowWin.Controls.Contains(ucAdministration.Instance))
            {
                panelShowWin.Controls.Add(ucAdministration.Instance);
                ucAdministration.Instance.Dock = DockStyle.Fill;
                ucAdministration.Instance.BringToFront();
            }
            else
                ucAdministration.Instance.BringToFront();
            msg("Administration");
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.MinimizeBox.Equals(true);
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("yyyy-MMM-dd   |   hh:mm:ss tt    ");
        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (cls_db_Connection.con)
                {
                    cls_db_Connection.open_connection();
                    MessageBox.Show("Connection Success !!","Connetion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    button1.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+"Connect Database and restart the program.","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                cls_db_Connection.close_connection();
            }

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (!panelShowWin.Controls.Contains(ucDashboard.Instance))
            {
                panelShowWin.Controls.Add(ucDashboard.Instance);
                ucDashboard.Instance.Dock = DockStyle.Fill;
                ucDashboard.Instance.BringToFront();
            }
            else
                ucDashboard.Instance.BringToFront();
            msg("Dashboard");
        }
    }
}
