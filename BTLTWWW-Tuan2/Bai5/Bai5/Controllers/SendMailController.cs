using Bai5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Bai5.Controllers
{
    public class SendMailController : Controller
    {
        // GET: SendMail
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Send(MailAttachment m)
        {
            string path = Server.MapPath("~/Doc/" + m.FileAttachment.FileName);
            m.FileAttachment.SaveAs(path);
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(m.MailSend);
                mail.To.Add(m.MailTo);
                mail.Subject = m.Subject;
                mail.Body = m.Content;
                mail.Attachments.Add(new Attachment(path));
                mail.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(m.MailSend, "01664338283Z*z");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
            return RedirectToAction("Index", "SendMail");
        }
    }
}