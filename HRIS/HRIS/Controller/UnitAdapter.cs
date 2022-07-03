using HRIS.Teaching;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HRIS.Controller
{
    public class UnitAdapter
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


        public static List<Unit> LoadAll()
        {
            GetConnection();
            MySqlDataReader rdr;
            List<Unit> data = new List<Unit>();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from unit", conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    data.Add(new Unit { Code = rdr.GetString(0), Title = rdr.GetString(1), Coordinator = rdr.GetInt32(2) });
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

