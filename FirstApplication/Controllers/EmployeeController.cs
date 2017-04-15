using FirstApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApplication.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        public ActionResult Employee()
        {
            List<Employee> EmployeList = new List<Employee>();
            Employee employee = new FirstApplication.Models.Employee();
            
            EmployeList.Add(new Employee{EmployeeId=1,Name="Frank",Departament="Sale"});
            EmployeList.Add(new Employee{EmployeeId=2,Name="Clear",Departament="RH"});

            ViewBag.Error = "Model Not Found ...";
            
            return View(EmployeList);
        }
	}
}