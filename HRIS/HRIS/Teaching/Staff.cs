using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Teaching
{
    public enum Campus { Hobart, Launceston,All };
    public enum Category { Academic, Technical, Admin, Casual, All };
    public enum Title { Dr, Ms, Mr};
    public class Staff
    {
        private string name { get; set; }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null)
                {
                    name = value;
                }

            }
        }
        public int id { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public Title Title { get; set; }
        public Campus Campus { get; set; }
        public string Phone { get; set; }
        public string Room { get; set; }
        public string Email { get; set; }
       // public URL Photo { get; set; }
        public Category Category { get; set; }
        public List<Event> ConsultationTime { get; set; }
        public string FullName { get; set; }
        public List<Unit> TeachingUnit { get; set; }

        
        public override string ToString()
        {
            return id + "/t" + FamilyName + "/t" + GivenName + "/t" + Title + "/t" + Campus + "/t" +Phone+ Room + "/t" + Email + "/t" + /*Photo + "/t" +*/ Category+ConsultationTime+TeachingUnit;
        }

    }
}
