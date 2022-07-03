using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIS.Teaching;

namespace HRIS.Controller
{
    public enum EventType { Lecture, Tutorial, Consultation }
    abstract public class HeatMapGenerator
    {
        public List<Event> Event { get; set; }
        public EventType EventType { get; set; }

        
        
    }
}
