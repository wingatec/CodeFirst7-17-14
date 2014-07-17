using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst7_17_14.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Timesheet> Timesheets { get; set; }
        public virtual Position Position { get; set; }
    }
}