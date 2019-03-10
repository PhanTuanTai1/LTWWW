using Bai9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai9.Controllers
{
    public class StudentManagerController : Controller
    {
        // GET: StudenManager
        public ActionResult Index()
        {
            return View(getListStudent());
        }
        public List<Student> getListStudent()
        {
            List<Student> lst = (List<Student>)Session["ListStudent"];
            if (lst == null) lst = new List<Student>();
            return lst;
        }
        public ActionResult Create()
        {
            return View("CreateStudent");
        }
        [HttpPost]
        public ActionResult AddStudent(Student s)
        {
            List<Student> lst = (List<Student>)Session["ListStudent"];
            if (lst == null) lst = new List<Student>();
            Student s1 = new Student();
            s1.Id = s.Id;
            s1.Name = s.Name;
            s1.Birthday = s.Birthday;
            s1.Address = s.Address;
            if(s.Pic != null)
            {
                string path = Server.MapPath("~/Pic/") + s.Pic.FileName;
                s1.PicUrl = s.Pic.FileName;
                s.Pic.SaveAs(path);
            }
            lst.Add(s1);
            Session["ListStudent"] = lst;
            return RedirectToAction("Index");
        }
        public ActionResult EditStudent(string idStudent)
        {
            List<Student> lst = (List<Student>)Session["ListStudent"];
            Student temp = lst.Single(x => x.Id == idStudent);
            return View("EditStudent", temp);
        }
        [HttpPost]
        public ActionResult Edit(Student s)
        {
            List<Student> lst = (List<Student>)Session["ListStudent"];
            Student temp = new Student();
            temp = lst.Single(x => x.Id == s.Id);
            if (s.Pic == null)
            {
                lst[lst.IndexOf(s)].Name = s.Name;
                lst[lst.IndexOf(s)].Address = s.Address;
                lst[lst.IndexOf(s)].Birthday = s.Birthday;
            }
            else if (s.Pic.FileName != null)
            {
                lst[lst.IndexOf(s)].Name = s.Name;
                lst[lst.IndexOf(s)].Address = s.Address;
                lst[lst.IndexOf(s)].Birthday = s.Birthday;
                string path = Server.MapPath("~/Pic/") + s.Pic.FileName;
                s.Pic.SaveAs(path);
                lst[lst.IndexOf(s)].PicUrl = s.Pic.FileName;
            }
            Session["ListStudent"] = lst;
            return View("Index", lst);
        }
        public ActionResult DeleteStudent(string idStudent)
        {
            List<Student> lst = (List<Student>)Session["ListStudent"];
            return View("DeleteStudent", lst.Single(x => x.Id == idStudent));
        }
        public ActionResult Delete(string idStudent)
        {
            List<Student> lst = (List<Student>)Session["ListStudent"];
            Student temp = lst.Single(x => x.Id == idStudent);
            string path = Server.MapPath("~/Pic/") + temp.PicUrl;
            System.IO.File.Delete(path);
            lst.Remove(temp);
            Session["ListStudent"] = lst;
            return View("Index", lst);
        }
        public ActionResult DetailStudent(string idStudent)
        {
            List<Student> lst = (List<Student>)Session["ListStudent"];
            return View("Details", lst.Single(x => x.Id == idStudent));
        }
    }
}