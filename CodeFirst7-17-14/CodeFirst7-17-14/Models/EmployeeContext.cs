using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; 

namespace CodeFirst7_17_14.Models
{
    public class EmployeeContext: DbContext 
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Timesheet> Timesheets { get; set; }

    }
}