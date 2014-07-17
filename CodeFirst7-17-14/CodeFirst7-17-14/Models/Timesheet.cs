using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst7_17_14.Models
{
    public class Timesheet
    {
        public int TimeSheetId { get; set; }
        public DateTime Date { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public  DateTime DailyHours { get; set; }

        public virtual Employee Employee { get; set; }
        
    }
}