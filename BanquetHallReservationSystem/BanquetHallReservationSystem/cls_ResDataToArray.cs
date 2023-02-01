using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace BanquetHallReservationSystem
{
    class cls_ResDataToArray
    {
     //   int maxSize;
        
        public static void AddResDataToArray()
        {
            string CCN = "SELECT * FROM `db_banquethallsreservationsystem`.`reservation` WHERE `reservation`.`reservation_status` = 'Pending'";
            MySqlDataAdapter da = new MySqlDataAdapter(CCN, cls_db_Connection.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int columnIndex = 0;  //single-column DataTable
            string[] ResIdArray = new string[dt.Rows.Count];  //[dt.Rows.Count] - define size of the array

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ResIdArray[i] = dt.Rows[i][columnIndex].ToString(); //Add data to array from the database
            }
        }
        
    }
}
