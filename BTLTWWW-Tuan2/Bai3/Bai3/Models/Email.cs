using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai3.Models
{
    public class Email
    {
        private string mailFrom;
        private string passForm;
        private string mailSend;
        private string subject;
        private string content;

        public string MailFrom
        {
            get
            {
                return mailFrom;
            }

            set
            {
                mailFrom = value;
            }
        }

        public string PassForm
        {
            get
            {
                return passForm;
            }

            set
            {
                passForm = value;
            }
        }

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