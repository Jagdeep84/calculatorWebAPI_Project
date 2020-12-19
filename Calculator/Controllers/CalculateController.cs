using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleCalc;

namespace Calculator.Controllers
{
    public class CalculateController : System.Web.Mvc.Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int num1,int num2,string operation)
        {
            SimpleCalc.SimpleCalc simpleCalc = new SimpleCalc.SimpleCalc();
            ViewData["result"] = simpleCalc.OperatorSwitch(num1,num2,operation);
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}