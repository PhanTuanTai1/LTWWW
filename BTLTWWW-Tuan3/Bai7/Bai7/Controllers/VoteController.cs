using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai7.Models;
namespace Bai7.Controllers
{
    public class VoteController : Controller
    {
        // GET: Vote
        public ActionResult Index()
        {
            return View(getListItem());
        }
        public List<Item> getListItem()
        {
            List<Item> lst = new List<Item>();
            Item i = new Item()
            {
                Id = 1,
                Name = "Ti Vi"
            };
            Item i1 = new Item()
            {
                Id = 2,
                Name = "Tủ lạnh"
            };
            lst.Add(i);
            lst.Add(i1);
            return lst;
        }
        public List<ItemVote> getListItemVote()
        {
            List<ItemVote> lst = new List<ItemVote>();
            ItemVote i = new ItemVote()
            {
                IdItem = 1,
                IdVote = 1,
                NameVote = "Mẫu mã gọn và đẹp"
            };
            ItemVote i1 = new ItemVote()
            {
                IdItem = 1,
                IdVote = 2,
                NameVote = "Màn hình sắt nét có nhiều màu đẹp"
            };
            lst.Add(i);
            lst.Add(i1);
            return lst;
        }
        [HttpGet]
        public ActionResult PartialVote(int id2)
        {
            return PartialView("PartialVote", getListItemVote().Where(x => x.IdItem == id2).ToList());
        }
    }
}