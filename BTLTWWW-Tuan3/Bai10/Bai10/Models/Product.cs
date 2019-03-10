using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai10.Models
{
    public class Product
    {
        private string idPro;
        private string name;
        private decimal unitPrice;
        private string urlImg;
        private HttpPostedFileBase img;

        public string IdPro
        {
            get
            {
                return idPro;
            }

            set
            {
                idPro = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public decimal UnitPrice
        {
            get
            {
                return unitPrice;
            }

            set
            {
                unitPrice = value;
            }
        }

        public string UrlImg
        {
            get
            {
                return urlImg;
            }

            set
            {
                urlImg = value;
            }
        }

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
    }
}