using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Teaching
{
    public enum ClassType { Lecture, Tutorial, Practical, Workshop, All };
    public class UnitClass
    {
        public int id { get; set; }
        public string Code { get; set; }
        public string Room { get; set; }
        public Campus Campus { get; set; }
        public ClassType ClassType { get; set; }
        public List<Event> ClassTime { get; set; }
        public int staff { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }

        public override string ToString()
        {

            return Room + Campus + ClassType + ClassTime + staff+Day+Start+End+staff;

        }
    }
}
