using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai2.Models;
namespace Bai2.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(Staff s)
        {
            var path = Server.MapPath("~/Img/" + s.File1.FileName);
            s.File1.SaveAs(path);
            string[] info = { s.MaNV.ToString(), s.TenNV, s.NgaySinh.ToString(), s.Luong.ToString(), s.File1.FileName };
            string pathfile = Server.MapPath("~/StaffInfo.txt");
            System.IO.File.WriteAllLines(pathfile, info);      
            return View("Index");
        }
        public ActionResult Open()
        {
            string pathfile = Server.MapPath("~/StaffInfo.txt");
            string[] info = System.IO.File.ReadAllLines(pathfile);
            Staff s = new Staff();
            s.MaNV = int.Parse(info[0]);
            s.TenNV = info[1];
            s.NgaySinh = DateTime.Parse(info[2]);
            s.Luong = decimal.Parse(info[3]);
            s.HinhNV = "../../Img/" + info[4];
            ViewBag.ID = s.MaNV;
            ViewBag.TenNV = s.TenNV;
            ViewBag.NgaySinh = s.NgaySinh.ToString();
            ViewBag.Luong = s.Luong;
            ViewBag.Img = s.HinhNV;
            return View("Index");
        }
    }
}