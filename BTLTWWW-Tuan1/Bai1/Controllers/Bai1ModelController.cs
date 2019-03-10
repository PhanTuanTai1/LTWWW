using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai1.Models;
namespace Bai1.Controllers
{
    public class Bai1ModelController : Controller
    {
        // GET: Bai1Model
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Cal cal)
        {
            switch (cal.Op)
            {
                case "+": { ViewBag.KetQua = cal.A + cal.B; break; }
                case "-": { ViewBag.KetQua = cal.A - cal.B; break; }
                case "*": { ViewBag.KetQua = cal.A * cal.B; break; }
                case "/": { ViewBag.KetQua = cal.A / cal.B; break; }
            }
            
            return View();
        }
    }
}