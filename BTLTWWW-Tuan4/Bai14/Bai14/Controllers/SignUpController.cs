using Bai14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CaptchaMvc.HtmlHelpers;
using System.IO;

namespace Bai14.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(SignUp su)
        {
            List<string> lstEx = new List<string>() { ".jpg", ".png", ".gif" };
            if (this.IsCaptchaValid("Vui lòng nhập kết quả") == false)
            {
                ViewBag.Captcha = "Vui lòng nhập kết quả đúng";
                return View(su);
            }
            if (su.Img != null)
            {
                string ex = Path.GetExtension(su.Img.FileName);
                if(lstEx.Contains(ex))
                {
                    su.Img.SaveAs(Server.MapPath("~/Img/" + su.Img.FileName));
                    return View("Success", su);
                }
                else
                {
                    return View(su);
                }
                //if (su.Img != null) 
                //
            }
            else
            {
                return View(su);
            }

        }
        public ActionResult Success()
        {
            return RedirectToAction("Index");
        }
    }
}