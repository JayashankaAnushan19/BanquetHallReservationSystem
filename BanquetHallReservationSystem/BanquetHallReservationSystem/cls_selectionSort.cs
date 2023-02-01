using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace BanquetHallReservationSystem
{
    class cls_selectionSort
    {
   /*     public static void MakeArrays()
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
                
                HallGuestsArray[j] = Convert.ToInt32(cmd);
            }
            
        } */

        public static void selectionSort()
        {
            try {
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

                    HallGuestsArray[j] = Convert.ToInt32(cmd);
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
                    }
                }
                
            }
            catch (Exception ex)
            {
                cls_showMessage.showMessage(ex.Message);
            }
            finally
            {

            }
        }
        // End of the selection sort
    }
}
