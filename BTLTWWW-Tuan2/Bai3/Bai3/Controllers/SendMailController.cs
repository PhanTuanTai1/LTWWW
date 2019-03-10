using Bai3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Bai3.Controllers
{
    public class SendMailController : Controller
    {
        // GET: SendMail
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Send(Email e)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(e.MailFrom);
                mail.To.Add(e.MailSend);
                mail.Subject = e.Subject;
                mail.Body = e.Content;
                mail.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient("Smtp.gmail.com", 587))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(e.MailFrom, e.PassForm);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
            return View("Index");
        }
    }
}