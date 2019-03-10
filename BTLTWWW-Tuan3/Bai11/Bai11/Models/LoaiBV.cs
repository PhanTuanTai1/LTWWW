using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai11.Models
{
    public class LoaiBV
    {
        private string idBV;
        private string tenLoai;

        public string IdBV
        {
            get
            {
                return idBV;
            }

            set
            {
                idBV = value;
            }
        }

        public string TenLoai
        {
            get
            {
                return tenLoai;
            }

            set
            {
                tenLoai = value;
            }
        }
    }
}