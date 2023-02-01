using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;
using System.IO;

namespace BanquetHallReservationSystem
{
    class cls_db_Connection
    {
        
public static MySqlConnection con = new MySqlConnection("Server=localhost;userid=root;password=;database=db_banquethallsreservationsystem;charSet=utf8;");


        public static void open_connection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
            }
        }


        public static void close_connection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        
    }//end Of connection class
}

