using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using HRIS.Teaching;
using HRIS.Controller;

namespace HRIS.Controller

{
    abstract class ClassAdapter
    {
        private const string db = "kit206";
        private const string user = "kit206";
        private const string pass = "kit206";
        private const string server = "alacritas.cis.utas.edu.au";
        static MySqlConnection conn;

        private static MySqlConnection GetConnection()
        {
            if (conn == null)
            {
                string connectionString = String.Format("Database={0};Data Source={1};User Id={2}; Password={3}", db, server, user, pass);
                conn = new MySqlConnection(connectionString);
            }
            return conn;
        }
        public static List<UnitClass> LoadAllClass()
        {
            GetConnection();
            MySqlDataReader rdr;
            List<UnitClass> data = new List<UnitClass>();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from class", conn);
                rdr = cmd.ExecuteReader();
                int i = 0;
                while (rdr.Read())
                {
                    data.Add(new UnitClass { id=i++, Code = rdr.GetString(0), Campus = StaffAdapter.ParseEnum<Campus>(rdr.GetString(1)), ClassType = StaffAdapter.ParseEnum<ClassType>(rdr.GetString(5)), Room = rdr.GetString(6), staff = rdr.GetInt32(7), Day=StaffAdapter.ParseEnum<DayOfWeek>(rdr.GetString(2)), Start=rdr.GetTimeSpan(3), End=rdr.GetTimeSpan(4)});
                }

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return data;
        }

        //public static void LoadClassTime()
        //{
        //    List<Event> data = new List<Event>();
        //    GetConnection();
        //    MySqlDataReader rdr;
        //    try
        //    {
        //        conn.Open();
        //        MySqlCommand cmd = new MySqlCommand("select day, start, end from class wheree", conn);
        //        rdr = cmd.ExecuteReader();
        //        while (rdr.Read())
        //        {
        //            data.Add(new Event { Day = StaffAdapter.ParseEnum<DayOfWeek>(rdr.GetString(3)), Start = rdr.GetTimeSpan(4), End = rdr.GetTimeSpan(5) });
        //        }
        //    }
        //    finally
        //    {
        //        if (conn != null)
        //        {
        //            conn.Close();
        //        }
        //    }
            
        //}

    }
}
