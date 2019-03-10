using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai2.Models
{
    public class Staff
    {
        private int maNV;
        private string tenNV;
        private DateTime ngaySinh;
        private decimal luong;
        private HttpPostedFileBase File;
        private string hinhNV;

        public int MaNV
        {
            get
            {
                return maNV;
            }

            set
            {
                maNV = value;
            }
        }

        public string TenNV
        {
            get
            {
                return tenNV;
            }

            set
            {
                tenNV = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public decimal Luong
        {
            get
            {
                return luong;
            }

            set
            {
                luong = value;
            }
        }

        public string HinhNV
        {
            get
            {
                return hinhNV;
            }

            set
            {
                hinhNV = value;
            }
        }

        public HttpPostedFileBase File1
        {
            get
            {
                return File;
            }

            set
            {
                File = value;
            }
        }
    }
}