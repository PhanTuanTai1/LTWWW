using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai5.Models
{
    public class MailAttachment
    {
        private string mailSend;
        private string mailTo;
        private string subject;
        private HttpPostedFileBase fileAttachment;
        private string content;

        public string MailSend
        {
            get
            {
                return mailSend;
            }

            set
            {
                mailSend = value;
            }
        }

        public string MailTo
        {
            get
            {
                return mailTo;
            }

            set
            {
                mailTo = value;
            }
        }

        public string Subject
        {
            get
            {
                return subject;
            }

            set
            {
                subject = value;
            }
        }

        public HttpPostedFileBase FileAttachment
        {
            get
            {
                return fileAttachment;
            }

            set
            {
                fileAttachment = value;
            }
        }

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }
    }
}