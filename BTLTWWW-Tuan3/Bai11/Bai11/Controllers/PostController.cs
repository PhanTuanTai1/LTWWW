using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai11.Models;
namespace Bai11.Controllers
{
    public class PostController : Controller
    {
        
        // GET: Post
        public ActionResult Index()
        {
            InitWrite();
            return View(getLstLoaiBV());
        }
        private List<LoaiBV> getLstLoaiBV()
        {
            List<LoaiBV> lst = new List<LoaiBV>();
            LoaiBV l1 = new LoaiBV()
            {
                IdBV = "1",
                TenLoai = "Công nghệ thông tin"
            };
            LoaiBV l2 = new LoaiBV()
            {
                IdBV = "2",
                TenLoai = "Kinh tế"
            };
            LoaiBV l3 = new LoaiBV()
            {
                IdBV = "3",
                TenLoai = "Truyện cười"
            };
            LoaiBV l4 = new LoaiBV()
            {
                IdBV = "4",
                TenLoai = "Tài chính ngân hàng"
            };
            lst.Add(l1);
            lst.Add(l2);
            lst.Add(l3);
            lst.Add(l4);
            return lst;
        }
        private void InitWrite()
        {
            List<Write> lst = new List<Models.Write>();
            Write w1 = new Write()
            {
                IdBV = "1",
                TypeName = "Công nghệ thông tin",
                IdWrite = "1",
                Title = "Java",
                ContentSub = "Java (phiên âm Tiếng Việt: 'Gia - va') là một ngôn ngữ lập trình hướng đối tượng (OOP) và dựa trên các lớp (class)[9]. Khác với phần lớn ngôn ngữ lập trình thông thường, thay vì biên dịch mã nguồn thành mã máy hoặc thông dịch mã nguồn khi chạy, Java được thiết kế để biên dịch mã nguồn thành bytecode, bytecode sau đó sẽ được môi trường thực thi (runtime environment) chạy.",
                ContentMain = "Trước đây, Java chạy chậm hơn những ngôn ngữ dịch thẳng ra mã máy như C và C++, nhưng sau này nhờ công nghệ 'biên dịch tại chỗ' - Just in time compilation, khoảng cách này đã được thu hẹp, và trong một số trường hợp đặc biệt Java có thể chạy nhanh hơn. Java chạy nhanh hơn những ngôn ngữ thông dịch như Python, Perl, PHP gấp nhiều lần. Java chạy tương đương so với C#, một ngôn ngữ khá tương đồng về mặt cú pháp và quá trình dịch/chạy"
            };
            lst.Add(w1);
            Session["ListWrite"] = lst;
        }
        public ActionResult Write(string id)
        {
            List<Write> lst = ((List<Write>)Session["ListWrite"]).Where(x=>x.IdBV == id).ToList();
            return PartialView("_Write",lst);
        }
        public ActionResult Detail(string id)
        {
            Write w = ((List<Write>)Session["ListWrite"]).Single(x => x.IdBV == id);
            return PartialView("_Detail", w);
        }
    }
}