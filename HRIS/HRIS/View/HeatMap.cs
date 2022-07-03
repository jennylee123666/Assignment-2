using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.View
{
    public class HeatMap
    {
        public string[] Day { get; set; }
        //public SolidColorBrush[] color;
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }

        public HeatMap()
        {

        }
    }
}
