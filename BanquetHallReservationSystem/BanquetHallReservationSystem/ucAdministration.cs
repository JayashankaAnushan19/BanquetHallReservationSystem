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
   
    
    public partial class ucAdministration : UserControl
    {
        
        private static ucAdministration _instance;
        public static ucAdministration Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAdministration();
                return _instance;
            }
        }
        public void Clear()
        {
            chbxReviewCheRes.Checked = false;
            txtResId.Clear();
            chbCurrentPass.Checked = false;
            chbNewPass.Checked = false;
            txtCurrentPass.Clear();
            txtNewPass.Clear();
            txtRetypeNewPass.Clear();
            imgHelpCan.Visible = false;
            bunifuThinButton21.Visible = true;
            lblWarnMessage.Visible = false;
            lblLocation.Text = "";
            lblResView.Text = "";
            listBoxPenResID.Items.Clear();
            listBoxHallID.Items.Clear();
            listBoxCompletedRes.Items.Clear();

        }

        public void reset()
        {
            Clear();
            lblWarnMessage.Visible = false;
            imgHelpCan.Visible = false;
            txtCurrentPass.UseSystemPasswordChar = true;
            txtNewPass.UseSystemPasswordChar = true;
            txtRetypeNewPass.UseSystemPasswordChar = true;
            btnCompRes.Enabled = true;
            tabpagResCon.Focus();
            listBoxPenResID.Items.Clear();
            listBoxHallID.Items.Clear();
            listBoxCompletedRes.Items.Clear();
        }

        public ucAdministration()
        {
            InitializeComponent();
            lblWarnMessage.Visible = false;
            imgHelpCan.Visible = false;
            txtCurrentPass.UseSystemPasswordChar = true;
            txtNewPass.UseSystemPasswordChar = true;
            txtRetypeNewPass.UseSystemPasswordChar = true;
            btnCompRes.Enabled = true;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            bunifuThinButton21.Visible = false;
            imgHelpCan.Visible = true;
            lblWarnMessage.Visible = true;
        }

        private void imgHelpCan_Click(object sender, EventArgs e)
        {
            lblWarnMessage.Visible = false;
            bunifuThinButton21.Visible = true;
            imgHelpCan.Visible = false;
        }

        private void tabconAdmin_Click(object sender, EventArgs e)
        {
            lblWarnMessage.Visible = false;
            imgHelpCan.Visible = false;
        }

        private void chbCurrentPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCurrentPass.Checked)
            {
                txtCurrentPass.UseSystemPasswordChar = false;
            }
            else
                txtCurrentPass.UseSystemPasswordChar = true;
        }

        private void chbNewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNewPass.Checked)
            {
                txtNewPass.UseSystemPasswordChar = false;
            }
            else
                txtNewPass.UseSystemPasswordChar = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            ucMain.Instance.BringToFront();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            Clear();
            ucMain.Instance.BringToFront();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            Clear();
            ucMain.Instance.BringToFront();
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            GetDataToGridview();
        }
        private void GetDataToGridview()
        {
            try
            {
                cls_db_Connection.open_connection();

                string CCN = "SELECT * FROM `db_banquethallsreservationsystem`.`reservation`";
                MySqlDataAdapter da = new MySqlDataAdapter(CCN, cls_db_Connection.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow[] returnrow = ds.Tables[0].Select("reservation_id='" + txtResId.Text + "'");  //Get data from user input for check
                DataRow dr = returnrow[0];

                string resID = dr["reservation_id"].ToString();
                string cusID = dr["customer_id"].ToString();    //use this for find customer name
                string hallId = dr["hotel_id"].ToString();
                string numOfGuest = dr["reservation_numberofguest"].ToString();
                 
                string myCommand = "SELECT * FROM `db_banquethallsreservationsystem`.`customer`"; //find customer name from customer id
                MySqlDataAdapter daa = new MySqlDataAdapter(myCommand, cls_db_Connection.con);
                DataSet dss = new DataSet();
                daa.Fill(dss);
                DataRow[] returnroww = dss.Tables[0].Select("customer_id='" + cusID + "'"); 
                DataRow drr = returnroww[0];

                string cusName = drr["customer_name"].ToString();

                

                lblResView.Text = "'"+resID+ "'\n'" + cusID + "'\n'" + cusName + "'\n'" + hallId + "'\n'" + numOfGuest + "'";

                try
                {
                    if (!(hallId == ""))
                    {
                        cls_db_Connection.open_connection();
                        string myCommand1 = "SELECT * FROM `db_banquethallsreservationsystem`.`hall`"; //Find hall from hall id
                        MySqlDataAdapter daa1 = new MySqlDataAdapter(myCommand1, cls_db_Connection.con);
                        DataSet dss1 = new DataSet();
                        daa1.Fill(dss1);
                        DataRow[] returnroww1 = dss1.Tables[0].Select("hall_id='" + hallId + "'");
                        DataRow drr1 = returnroww1[0];

                        lblLocation.Text = "-- "+drr1["hall_location"].ToString();
                    }
                    else
                    {
                        lblLocation.Text = "";
                        MessageBox.Show("This reservation have not matching halls yet.","Unhandlled reservation",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        btnCompRes.Enabled = false;
                    }
                }
                catch
                {

                }
                finally
                {
                    cls_db_Connection.close_connection();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message +"  Wrong Reservation Number", "Banquet Hall Reservation System", MessageBoxButtons.OK);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {

        }

        private void btnCompRes_Click(object sender, EventArgs e)
        {
            try
            {
                cls_db_Connection.open_connection();

                string CCN = "SELECT * FROM `db_banquethallsreservationsystem`.`reservation`";
                MySqlDataAdapter da = new MySqlDataAdapter(CCN, cls_db_Connection.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow[] returnrow = ds.Tables[0].Select("reservation_id='" + txtResId.Text + "'");  //Get data from user input for check
                DataRow dr = returnrow[0];

                string hallId = dr["hotel_id"].ToString();
                if(hallId=="")
                {
                    if(MessageBox.Show("This reservation have not matching hall locations, then reservation will be delete. Do you want to continue?", "Delete Reservation !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        
                        string myCommand1 = "DELETE FROM `reservation` WHERE `reservation`.`reservation_id` = '" + txtResId.Text + "'";
                        MySqlCommand cmd1 = new MySqlCommand(myCommand1, cls_db_Connection.con);
                        cmd1.ExecuteNonQuery();
                    }
                    else
                    {
                        
                    }

                }
                else
                {
                    cls_db_Connection.open_connection();
                    string myCommand1 = "DELETE FROM `hall` WHERE `hall`.`hall_id` = '" + hallId + "';";
                    MySqlCommand cmd1 = new MySqlCommand(myCommand1, cls_db_Connection.con);
                    cmd1.ExecuteNonQuery();
                    string myCommand = "DELETE FROM `reservation` WHERE `reservation`.`reservation_id` = '" + txtResId.Text + "';";
                    MySqlCommand cmd = new MySqlCommand(myCommand, cls_db_Connection.con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Reservation Completed !!!", "Complete.", MessageBoxButtons.OK);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cls_db_Connection.close_connection();
                Clear();

            }
        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnCheckRes_Click(object sender, EventArgs e)
        {
            reset();

            //enter code for if click checkbox then recheck checked reservations.
            //need to informe that if click this button all reservation will be recheck and so, if there is confirmed reservation need to complete

            if (chbxReviewCheRes.Checked == true)
            {
                if((MessageBox.Show("In This process, all reservation will be recheck and so, if there is confirmed reservation need to complete. If not process will reboot.", "Re Check checked reservations", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) ==DialogResult.OK)
                {
                    //enter code for if click checkbox then recheck checked reservations.
                    MessageBox.Show("Reservation Re-checking complete !!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chbxReviewCheRes.Checked = false;
                }
                else
                {
                    chbxReviewCheRes.Checked = false;
                }
            }
            else
            {
                checkPendingReservation();
                MessageBox.Show("Reservation checking complete !!","Complete",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
                        
        }




        private void chbxReviewCheRes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnInfCus_Click(object sender, EventArgs e)
        {

        }

        public void checkPendingReservation()
        {

            try
            {

                //add Reservation Ids to Array where status = 'pending'
                cls_db_Connection.open_connection(); //Open connection to database

                string CCN = "SELECT * FROM `db_banquethallsreservationsystem`.`reservation` WHERE `reservation`.`reservation_status` = 'Pending'";
                MySqlDataAdapter da = new MySqlDataAdapter(CCN, cls_db_Connection.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int columnIndex = 0; //single-column DataTable
                string[] ResIdArray = new string[dt.Rows.Count]; //define size of the array

                listBoxPenResID.Items.Add("Pending Reservation IDs");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ResIdArray[i] = dt.Rows[i][columnIndex].ToString();
                    listBoxPenResID.Items.Add(ResIdArray[i]);
                }


                //add Hall Ids to Array where status = 'pending'

                cls_db_Connection.open_connection(); //Open connection to database

                string CCN1 = "SELECT * FROM `db_banquethallsreservationsystem`.`hall` WHERE `hall`.`hall_status` = 'Pending'";
                MySqlDataAdapter da1 = new MySqlDataAdapter(CCN1, cls_db_Connection.con);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                int columnIndex1 = 0; //single-column DataTable
                string[] HallIdArray = new string[dt1.Rows.Count]; //define size of the array

                listBoxHallID.Items.Add("Pending Hall IDs");
                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    HallIdArray[j] = dt1.Rows[j][columnIndex1].ToString();
                    listBoxHallID.Items.Add(HallIdArray[j]);
                }

                //Making two arrys using Reservation IDs and Hall IDs are complete

                //Reservation checking operation start fom here
                listBoxCompletedRes.Items.Add("Matched Reservations ...");
                listBoxCompletedRes.Items.Add("Reservation ID" + " : " + "Customer Name" + " : " + "Matched Location" + " : " + "Status");

                for (int k = 0; k < ResIdArray.Length; k++)
                {
                    cls_db_Connection.open_connection(); //Open connection to database

                    //Import Reservation location using array index
                    string findResLoc = "SELECT * FROM `db_banquethallsreservationsystem`.`reservation`";
                    MySqlDataAdapter CmdResLoc = new MySqlDataAdapter(findResLoc, cls_db_Connection.con);
                    DataSet CmdResLocc = new DataSet();
                    CmdResLoc.Fill(CmdResLocc);
                    DataRow[] returnrow = CmdResLocc.Tables[0].Select("reservation_id='" + ResIdArray[k] + "'");  //Get data from database using array indexes
                    DataRow dr = returnrow[0];

                    string resLocation = dr["reservation_location"].ToString();

                    for (int l = 0; l < HallIdArray.Length; l++)
                    {
                        //Import Hall location using array index
                        string findHallLocatiion = "SELECT * FROM `db_banquethallsreservationsystem`.`hall`";
                        MySqlDataAdapter CmdHallLoc = new MySqlDataAdapter(findHallLocatiion, cls_db_Connection.con);
                        DataSet CmdHallLocc = new DataSet();
                        CmdHallLoc.Fill(CmdHallLocc);
                        DataRow[] returnrow1 = CmdHallLocc.Tables[0].Select("hall_id = '" + HallIdArray[l] + "'");  //Get data from database using array indexes
                        DataRow dr1 = returnrow1[0];

                        string hallLocation = dr1["hall_location"].ToString();

                        if (resLocation == hallLocation)
                        {
                            //Import Reservated number of guests using array index
                            string findResNumberOfGuests = "SELECT * FROM `db_banquethallsreservationsystem`.`reservation`";
                            MySqlDataAdapter CmdResNumberOfGuests = new MySqlDataAdapter(findResNumberOfGuests, cls_db_Connection.con);
                            DataSet CmdResNumberOfGuestsc = new DataSet();
                            CmdResNumberOfGuests.Fill(CmdResNumberOfGuestsc);
                            DataRow[] returnrow2 = CmdResNumberOfGuestsc.Tables[0].Select("reservation_id='" + ResIdArray[k] + "'");  //Get data from database using array indexes
                            DataRow dr2 = returnrow2[0];

                            string ResNumberOfGuests = dr2["reservation_numberofguest"].ToString();
                            int ResGuestCount = Convert.ToInt16(ResNumberOfGuests);

                            //Import Hall guest using array index
                            string findHallGuests = "SELECT * FROM `db_banquethallsreservationsystem`.`hall`";
                            MySqlDataAdapter CmdHallGuests = new MySqlDataAdapter(findHallGuests, cls_db_Connection.con);
                            DataSet CmdHallGuestsc = new DataSet();
                            CmdHallGuests.Fill(CmdHallGuestsc);
                            DataRow[] returnrow3 = CmdHallGuestsc.Tables[0].Select("hall_id='" + HallIdArray[l] + "'");  //Get data from user input for check
                            DataRow dr3 = returnrow3[0];

                            string HallGuest = dr3["hall_numberofguest"].ToString();
                            int HallGuestCount = Convert.ToInt16(HallGuest);

                            if (!(ResGuestCount > HallGuestCount))
                            {
                                cls_db_Connection.open_connection();

                                //update hall satus = Checked
                                string myCommand1 = "UPDATE `hall` SET `hall_status` = 'Checked' WHERE `hall`.`hall_id` = '" + HallIdArray[l] + "'";
                                MySqlCommand cmd1 = new MySqlCommand(myCommand1, cls_db_Connection.con);
                                cmd1.ExecuteNonQuery();

                                // update reservation status=checked as hallid= HallIdArray[l] where reservation ID = ResIdArray[k]
                                string myCommand = "UPDATE `reservation` SET `reservation_status` = 'Checked',`hotel_id`='" + HallIdArray[l] + "' WHERE `reservation`.`reservation_id` ='" + ResIdArray[k] + "';";
                                MySqlCommand cmd = new MySqlCommand(myCommand, cls_db_Connection.con);
                                cmd.ExecuteNonQuery();

                                //find customer id and reserved location
                                string findCusId = "SELECT * FROM `db_banquethallsreservationsystem`.`reservation`";
                                MySqlDataAdapter CmdfindCusId = new MySqlDataAdapter(findCusId, cls_db_Connection.con);
                                DataSet findCusIdc = new DataSet();
                                CmdfindCusId.Fill(findCusIdc);
                                DataRow[] returnrowe = findCusIdc.Tables[0].Select("reservation_id='" + ResIdArray[k] + "'");  //Get data from database using array indexes
                                DataRow dre = returnrowe[0];

                                string cusIdSelected = dre["customer_id"].ToString();
                                string locationSelected = dre["reservation_location"].ToString();

                                //find customer name through customer id
                                string findCusIda = "SELECT * FROM `db_banquethallsreservationsystem`.`customer`";
                                MySqlDataAdapter CmdfindCusIda = new MySqlDataAdapter(findCusIda, cls_db_Connection.con);
                                DataSet findCusIdca = new DataSet();
                                CmdfindCusIda.Fill(findCusIdca);
                                DataRow[] returnrowea = findCusIdca.Tables[0].Select("customer_id='" + cusIdSelected + "'");  //Get data from database 
                                DataRow drea = returnrowea[0];

                                string cusName = drea["customer_name"].ToString();

                                //Show matched reservations in a ListBox
                                listBoxCompletedRes.Items.Add("     " + ResIdArray[k]+" to "+HallIdArray[l] + "     " + " : " + "     " + "'" + cusName + "' " + "     " + " : " + "'" + locationSelected + "'" + "     " + " : " + "     " + "Customer Informed");

                            }
                        }
                        else
                        {
                            // Add reservation to end of the array
                            // This mean its add to last row of the database
                        }

                    }
                } //Reservation checking operation end fom here
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Show syntax or related errors
            }
            finally
            {
                cls_db_Connection.close_connection(); //Close database connection
            }
        }
        public void checkCheckedReservation()
        {
            //Code
        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {

            try
            {
                cls_db_Connection.open_connection();

                //Add HallIds to Array
                string CCN1 = "SELECT * FROM `db_banquethallsreservationsystem`.`hall` WHERE `hall`.`hall_status` = 'Pending'";
                MySqlDataAdapter da1 = new MySqlDataAdapter(CCN1, cls_db_Connection.con);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                int columnIndex1 = 0; //single-column DataTable
                string[] HallIdArray = new string[dt1.Rows.Count]; //[dt1.Rows.Count] - define size of the array
                int[] HallGuestsArray = new int[dt1.Rows.Count];

                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    HallIdArray[j] = dt1.Rows[j][columnIndex1].ToString(); //Add Hall data to array from the database

                    string CCN = "SELECT `hall_numberofguest` FROM `db_banquethallsreservationsystem`.`hall` WHERE `hall`.`hall_id`='" + HallIdArray[j] + "'";
                    MySqlCommand cmd = new MySqlCommand(CCN, cls_db_Connection.con);
                    cmd.ExecuteNonQuery();
                    
                    HallGuestsArray[j] = Convert.ToInt32(cmd.ExecuteNonQuery());   //Conert string value to integer value
                }

                //pos_min is short for position of min

                int pos_min, temp;
                string temp1;

                for (int i = 0; i < HallGuestsArray.Length - 1; i++)
                {
                    pos_min = i; //set pos_min to the current index of array

                    for (int j = i + 1; j < HallGuestsArray.Length; j++)
                    {
                        if (HallGuestsArray[j] < HallGuestsArray[pos_min])
                        {
                            // pos_min will keeo track of the index that min is in, thus is needed 
                            pos_min = j;
                        }
                    }

                    // if pos_min no longer ezuals i than a smaller value must have been found, so a swap must be

                    if (pos_min != i)
                    {
                        temp = HallGuestsArray[i];
                        temp1 = HallIdArray[i];

                        HallGuestsArray[i] = HallGuestsArray[pos_min];
                        HallIdArray[i] = HallIdArray[pos_min];

                        HallGuestsArray[pos_min] = temp;
                        HallIdArray[pos_min] = temp1;

                        listBoxSortHallID.Items.Add(HallIdArray[i]); // Add sorted data to list box
                        listBoxSortGuestNumber.Items.Add(HallGuestsArray[i]); // Add sorted data to list box
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error "+"     "+ex.Message);
            }
            finally
            {
                cls_db_Connection.close_connection();
            }

        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            try
            {
                cls_db_Connection.open_connection();

                //Add HallIds to Array
                string CCN1 = "SELECT * FROM `db_banquethallsreservationsystem`.`hall` WHERE `hall`.`hall_status` = 'Pending'";
                MySqlDataAdapter da1 = new MySqlDataAdapter(CCN1, cls_db_Connection.con);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                int columnIndex1 = 0; //single-column DataTable
                string[] HallIdArray = new string[dt1.Rows.Count]; //[dt1.Rows.Count] - define size of the array
                int[] HallGuestsArray = new int[dt1.Rows.Count];

                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    HallIdArray[j] = dt1.Rows[j][columnIndex1].ToString(); //Add Hall data to array from the database

                    string CCN = "SELECT `hall_numberofguest` FROM `db_banquethallsreservationsystem`.`hall` WHERE `hall`.`hall_id`='" + HallIdArray[j] + "'";
                    MySqlCommand cmd = new MySqlCommand(CCN, cls_db_Connection.con);
                    cmd.ExecuteNonQuery();

                    HallGuestsArray[j] = Convert.ToInt32(cmd.ExecuteNonQuery());   //Conert string value to integer value
                }

                int temp;
                string temp1;

                for (int j = 0; j <= HallGuestsArray.Length - 2; j++)
                {
                    for (int i = 0; i <= HallGuestsArray.Length - 2; i++)
                    {
                        if (HallGuestsArray[i] > HallGuestsArray[i + 1])
                        {
                            temp = HallGuestsArray[i + 1];
                            temp1 = HallIdArray[i + 1];

                            HallGuestsArray[i + 1] = HallGuestsArray[i];
                            HallIdArray[i + 1] = HallIdArray[i];

                            HallGuestsArray[i] = temp;
                            HallIdArray[i] = temp1;

                            listBoxSortHallID.Items.Add(HallIdArray[i]); // Add sorted data to list box
                            listBoxSortGuestNumber.Items.Add(HallGuestsArray[i]); // Add sorted data to list box

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + "     " + ex.Message);
            }
            finally
            {
                cls_db_Connection.close_connection();
            }
        }

        private void tabpageSort_Click(object sender, EventArgs e)
        {

        }
    }
}








// Start of the QuickSort 
class GFG
{

    /* This function takes last element as pivot, 
    places the pivot element at its correct 
    position in sorted array, and places all smaller 
    (smaller than pivot) to left of pivot and all 
    greater elements to right of pivot */
    static int partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];

        // index of smaller element 
        int i = (low - 1);
        for (int j = low; j < high; j++)
        {
            // If current element is smaller 
            // than or equal to pivot 
            if (arr[j] <= pivot)
            {
                i++;

                // swap arr[i] and arr[j] 
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        // swap arr[i+1] and arr[high] (or pivot) 
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;

        return i + 1;
    }


    /* The main function that implements QuickSort() 
    arr[] --> Array to be sorted, 
	low --> Starting index, 
	high --> Ending index */
    static void quickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {

            /* pi is partitioning index, arr[pi] is now 
            at right place */
            int pi = partition(arr, low, high);

            // Recursively sort elements before 
            // partition and after partition 
            quickSort(arr, low, pi - 1);
            quickSort(arr, pi + 1, high);
        }
    }

    // A utility function to print array of size n 
    static void printArray(int[] arr, int n)
    {
        for (int i = 0; i < n; ++i)
        { 
            foreach (int j in arr)
            {
                myList.add(arr[i]);
            }
            grdCusView.Rows.Add(myList.ToArray());

        }


    }

    // Driver program 
    public void quickSort_BigToSmall()
    {

        cls_db_Connection.open_connection();

        //Add HallIds to Array
        string CCN1 = "SELECT * FROM `db_banquethallsreservationsystem`.`hall` WHERE `hall`.`hall_status` = 'Pending'";
        MySqlDataAdapter da1 = new MySqlDataAdapter(CCN1, cls_db_Connection.con);
        DataTable dt1 = new DataTable();
        da1.Fill(dt1);
        int columnIndex1 = 0; //single-column DataTable

        //create a arry using hall Ids.
        int[] arr = new int[dt1.Rows.Count]; //[dt1.Rows.Count] - define size of the array 
        int n = arr.Length;
        quickSort(arr, 0, n - 1);
        printArray(arr, n);
    }
}
// End of the quick sort

