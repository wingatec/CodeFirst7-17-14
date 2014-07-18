using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst7_17_14.Models
{
    public class Timesheet
    {
        public int TimeSheetId { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.Time)]
        public DateTime TimeIn { get; set; }
        [DataType(DataType.Time)]
        public DateTime TimeOut { get; set; }
        public  DateTime DailyHours { get; set; }

        public virtual Employee Employee { get; set; }
        
    }
}