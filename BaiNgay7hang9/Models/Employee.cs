using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiNgay7hang9.Models
{
    public class Employee
    {
        [key]
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime EmployeeBirth { get; set; }
    }
}