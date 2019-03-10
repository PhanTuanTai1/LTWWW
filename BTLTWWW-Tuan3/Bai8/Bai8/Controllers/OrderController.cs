using Bai8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai8.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoadPie()
        {
            return PartialView("LoadPie", getListPie());
        }
        public List<Pie> getListPie()
        {
            List<Pie> lst = new List<Pie>();
            Pie p = new Pie()
            {
                NamePie = "Hamburger"
            };
            Pie p1 = new Pie()
            {
                NamePie = "Bánh bò"
            };
            Pie p2 = new Pie()
            {
                NamePie = "Bánh bò nướng"
            };
            lst.Add(p);
            lst.Add(p1);
            lst.Add(p2);
            return lst;
        }
        Pie temp;
        public ActionResult LoadListOrder(string namePie, int soLuong)
        {

            if (namePie != "" && soLuong != 0)
            {
                temp = new Pie()
                {
                    NamePie = namePie,
                    SoLuong = soLuong
                };
            }
            List<Pie> lst = (List<Pie>)Session["ListPie"];
            if (lst == null)
            {
                lst = new List<Pie>();
                if (temp != null)
                {
                    lst.Add(temp);
                    temp = null;
                }
                Session["ListPie"] = lst;
            }
            else
            {
                if (temp != null) lst.Add(temp);
                Session["ListPie"] = lst;
            }
            return PartialView("ListOrder", lst);
        }
        [HttpPost]
        public ActionResult PrintOrder(DonHang dh)
        {
            List<Pie> lst = (List<Pie>)Session["ListPie"];
            dh.LstPie = lst;
            Session["ListPie"] = null;
            return View("Bill", dh);
        }
    }
}