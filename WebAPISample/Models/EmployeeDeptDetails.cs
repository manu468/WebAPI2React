using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPISample.Models
{
    public class EmployeeDeptDetails
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? DeptId { get; set; }
        public string DeptName { get; set; }
        public string DeptLoc { get; set; }
    }
}