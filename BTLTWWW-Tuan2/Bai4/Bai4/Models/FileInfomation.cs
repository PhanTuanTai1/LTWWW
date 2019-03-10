using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai4.Models
{
    public class FileInfomation
    {
        private HttpPostedFileBase img;
        private HttpPostedFileBase document;

        public HttpPostedFileBase Img
        {
            get
            {
                return img;
            }

            set
            {
                img = value;
            }
        }

        public HttpPostedFileBase Document
        {
            get
            {
                return document;
            }

            set
            {
                document = value;
            }
        }
    }
}