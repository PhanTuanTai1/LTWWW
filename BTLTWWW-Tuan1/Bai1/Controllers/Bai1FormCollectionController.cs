using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai1.Controllers
{
    public class Bai1FormCollectionController : Controller
    {
        // GET: Bai1FormCollection
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection frm)
        {
            string op = frm["op"];
            double a = double.Parse(frm["a"]);
            double b = double.Parse(frm["b"]);
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