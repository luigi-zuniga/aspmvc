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
            ViewBag.NameUser = "Luigi";
            List<string> ListData = new List<string>();
            ListData.Add("78 Kg");
            ListData.Add("1,75 cm");
            ListData.Add("27 Year Old");
            ViewBag.Data = ListData;
            //Error Message if ViewBag.List is equals null
            ViewBag.Error = "Error :(";
            return View();
        }
	}
}