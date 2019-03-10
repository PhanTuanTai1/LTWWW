using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai10.Models;
namespace Bai10.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> p = getListProduct();
            //int index;
            //if (p.Count == 0) index = 0;
            //else if (p.Count / 4 != 0) index = (p.Count / 4) + 1;
            //else index = p.Count / 4;
            //ViewBag.Loop = index;
            return View(p);
        }
        public List<Product> getListProduct()
        {
            List<Product> lst = (List<Product>)Session["ListProduct"];
            if (lst == null) lst = new List<Product>();
            //Session["ListProduct"] = lst;
            return lst;
        }
        public ActionResult Detail(string id)
        {
            List<Product> lst = (List<Product>)Session["ListProduct"];
            return View("Detail", lst.SingleOrDefault(x => x.IdPro == id));
        }
        public ActionResult CreateProduct(Product p)
        {
            string path = Server.MapPath("~/Img/" + p.Img.FileName);
            p.Img.SaveAs(path);
            p.UrlImg = p.Img.FileName;
            List<Product> lst = (List<Product>)Session["ListProduct"];
            if (lst == null) lst = new List<Product>();
            lst.Add(p);
            Session["ListProduct"] = lst;
            return RedirectToAction("Index");
        }
        public ActionResult RenderModal()
        {
            return PartialView("_CreateProduct");
        }
        public ActionResult Delete()
        {
            return View("Delete", getListProduct());
        }
        public ActionResult Edit()
        {
            return View("Edit", getListProduct());
        }
        public ActionResult DeleteProduct(string id)
        {
            List<Product> lst = (List<Product>)Session["ListProduct"];
            lst.Remove(lst.Single(x => x.IdPro == id));
            Session["ListProduct"] = lst;
            return RedirectToAction("Delete", "Product");
        }
        public ActionResult EditProduct(Product p)
        {
            List<Product> lst = (List<Product>)Session["ListProduct"];
            Product temp = lst.Single(x => x.IdPro == p.IdPro);
            if (p.Img == null)
            {
                temp.Name = p.Name;
                temp.UnitPrice = p.UnitPrice;
            }
            else if (p.Img != null)
            {
                temp.Name = p.Name;
                temp.UnitPrice = p.UnitPrice;
                temp.UrlImg = p.Img.FileName;
            }
            Session["ListProduct"] = lst;
            return RedirectToAction("Edit", "Product", lst);
        }
        public ActionResult RenderEdit(string id)
        {
            return PartialView("_RenderEdit", getListProduct().Single(x => x.IdPro == id));
        }
    }
}