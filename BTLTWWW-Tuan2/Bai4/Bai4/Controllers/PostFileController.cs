using Bai4.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai4.Controllers
{
    public class PostFileController : Controller
    {
        // GET: PostFile
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Upload(FileInfomation f)
        {
            string pathImg = Server.MapPath("~/Img/" + f.Img.FileName);
            string pathDoc = Server.MapPath("~/Doc/" + f.Document.FileName);
            f.Img.SaveAs(pathImg);
            f.Document.SaveAs(pathDoc);
            ViewBag.Link = "~/Img/" + f.Img.FileName;
            ViewBag.NameF = Path.GetFileName(pathDoc);
            ViewBag.TypeF = MimeMapping.GetMimeMapping(f.Document.FileName);
            FileInfo info = new FileInfo(pathDoc);
            ViewBag.SizeF = info.Length;
            return View("Result");
        }
       
    }
}