using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst7_17_14.Models
{
    public class Timesheet
    {
        
        public DateTime Date { get; set; }
        public int TimeIn { get; set; }
        public int TimeOut { get; set; }
        public int DailyHours { get; set; }

        public virtual Employee Employee { get; set; }
        
    }
}