using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIS.Teaching;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace HRIS.Controller
{
    abstract class StaffAdapter
    {
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }
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


        public static List<Staff> LoadAll()
        {
            GetConnection();
            MySqlDataReader rdr;
            List<Staff> data = new List<Staff>();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from staff", conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    data.Add(new Staff { id = rdr.GetInt32(0), GivenName = rdr.GetString(1), FamilyName = rdr.GetString(2), Title = ParseEnum<Title>(rdr.GetString(3)), Campus=ParseEnum<Campus>(rdr.GetString(4)), Phone = rdr.GetString(5), Room = rdr.GetString(6), Email = rdr.GetString(7), Category=ParseEnum<Category>(rdr.GetString(9))});
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
        public static List<Event> LoadConsultationTime(int id)
        {
            List<Event> data = new List<Event>();
            GetConnection();
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select day, start, end from consultation where staff_id = ?id", conn);
                cmd.Parameters.AddWithValue("id", id);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    data.Add(new Event { Day = ParseEnum<DayOfWeek>(rdr.GetString(0)), Start = rdr.GetTimeSpan(1), End = rdr.GetTimeSpan(2) });
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
        public static List<Unit> LoadTeachingUnit(int id)
        {
            List<Unit> data = new List<Unit>();
            GetConnection();
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select code, title from unit where coordinator = ?id", conn);
                cmd.Parameters.AddWithValue("id", id);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    data.Add(new Unit { Code = rdr.GetString(0), Title = rdr.GetString(1)});
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

    }
}
