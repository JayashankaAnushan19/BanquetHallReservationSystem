using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace BanquetHallReservationSystem
{
    class cls_HallDataToArray
    {
        public static void AddHallDataToArray()
        {
            string CCN1 = "SELECT * FROM `db_banquethallsreservationsystem`.`hall` WHERE `hall`.`hall_status` = 'Pending'";
            MySqlDataAdapter da1 = new MySqlDataAdapter(CCN1, cls_db_Connection.con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            int columnIndex1 = 0; //single-column DataTable
            string[] HallIdArray = new string[dt1.Rows.Count]; //[dt1.Rows.Count] - define size of the array

            for (int j = 0; j < dt1.Rows.Count; j++)
            {
                HallIdArray[j] = dt1.Rows[j][columnIndex1].ToString(); //Add Hall data to array from the database
            }
        }
    }
}
