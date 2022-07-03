using HRIS.Teaching;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIS.Controller;

namespace HRIS.Controller
{
    public class StaffController
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
        private List<Staff> staff;
        public List<Staff> Workers { get { return staff; } set { } }

        private ObservableCollection<Staff> viewableStaff;
        public ObservableCollection<Staff> VisibleWorkers { get { return viewableStaff; } set { } }

        
        
        public StaffController()
        {
            staff = StaffAdapter.LoadAll();
            staff = staff.OrderBy(Staff => Staff.FamilyName).ToList();
            viewableStaff = new ObservableCollection<Staff>(staff);
            foreach (Staff e in staff)
            {
                
                e.ConsultationTime = StaffAdapter.LoadConsultationTime(e.id);
                e.TeachingUnit = StaffAdapter.LoadTeachingUnit(e.id);
                e.FullName = e.GivenName + " " + e.FamilyName + " " + e.Title;
            }
        }

        public ObservableCollection<Staff> GetViewableList()
        {
            return VisibleWorkers;
        }


        public void FilterByCategory(Category category)
        {
            if (category != Category.All)
            {
                var filtered = from Staff e in staff where e.Category == category select e;
                viewableStaff.Clear();
                //Converts the result of the LINQ expression to a List and then calls viewableStaff.Add with each element of that list in turn
                filtered.ToList().ForEach(viewableStaff.Add);
            }
            else
            {
                var filtered = from Staff e in staff select e;
                viewableStaff.Clear();
                filtered.ToList().ForEach(viewableStaff.Add);
            }

        }
        public void FilterByInput(String str)
        {
              var filtered = from Staff e in staff where e.FullName.ToLower().Contains(str.ToLower()) select e;
              viewableStaff.Clear();
                //Converts the result of the LINQ expression to a List and then calls viewableStaff.Add with each element of that list in turn
              filtered.ToList().ForEach(viewableStaff.Add);

         
        }
        
            
        
    }
    
}
