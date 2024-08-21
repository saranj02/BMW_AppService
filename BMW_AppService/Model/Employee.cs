using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMW_AppService.Model
{
    public class Employee
    {
        public string EmployeeCode { get; set; }
        public string NameTitle { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoin { get; set; }

        public string Position { get; set; }
        public decimal Salary { get; set; }
        //public List<Department> DepartmentName { get; set; }
        public int DepartmentCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string LastUpdateBy { get; set; }
       

    }
}