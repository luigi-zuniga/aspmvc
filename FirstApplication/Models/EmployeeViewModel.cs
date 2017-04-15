using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApplication.Models
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int DepartamentId { get; set; }
        public string Address { get; set; }
    }
}