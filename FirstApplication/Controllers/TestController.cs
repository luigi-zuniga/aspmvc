using FirstApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApplication.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public ActionResult Index()
        {
            EmployeeEntities db = new EmployeeEntities();
            Employee employee = db.Employee.SingleOrDefault(x => x.EmployeeId == 1);

            EmployeeViewModel employeeVm = new EmployeeViewModel();

            employeeVm.EmployeeId = employee.EmployeeId;
            employeeVm.DepartamentId = employee.DepartamentId;
            employeeVm.Name = employee.Name;
            employeeVm.Address = employee.Address;

            @ViewBag.Error = "No data found...";

            return View(employeeVm);
        }
	}
}