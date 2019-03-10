using Bai6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai6.Controllers
{
    public class AlbumController : Controller
    {
        // GET: Album
        public ActionResult Index()
        {
            return View(getListHoa());
        }
        private List<Hoa> getListHoa()
        {
            List<Hoa> lst = new List<Hoa>();
            lst.Add(new Hoa()
            {
                IdHoa = 1,
                TenHoa = "City",
                Extend = "jpg"
            });
            return lst;
        }
        public ActionResult getImg(int id)
        {
            ViewBag.Img = "~/Img/" + id + ".jpg";
            ViewBag.TenHoa = getListHoa().Single(x => x.IdHoa == id).TenHoa;
            return PartialView("_PartialImg");
        }
    }
}