using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai1.Controllers
{
    public class Bai1ArgumentController : Controller
    {
        // GET: Bai1Argument
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(double a,double b,string op = "+")
        {
            //double temp;
            switch (op)
            {
                case "+": { ViewBag.KetQua = a + b; break; }
                case "-": { ViewBag.KetQua = a - b; break; }
                case "*": { ViewBag.KetQua = a * b; break; }
                case "/": { ViewBag.KetQua = a / b; break; }
            }
            return View();
        }
    }
}