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

            //Difference between ViewBag - ViewData - TempData (TempData Peak and Keep)
            ViewBag.EmployeeList = EmployeList;
            
            //ViewData["EmployeeList"] = EmployeList;
            
            //ViewBag
            ViewBag.EmployeeNameVB = "Luigi";

            //ViewData
            ViewData["EmployeeNameVD"]= "Tim";
            //TempData
            TempData["EmployeeNameTD"] = "Katherine";


            //This Method can pass value be preserved
            //Only when we want to redirect on Second Page the use value Keep
            TempData.Keep();

            return View();
        }

        public ActionResult SecondPageEmployee() 
        {
            return View();
        }
	}
}