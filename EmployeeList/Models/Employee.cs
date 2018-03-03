using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeList.Models
{
    public class Employee
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime AddDate { set; get; }
        public double Salary { set; get; }
        public IList<Project> Projects { set; get; }
    }
}