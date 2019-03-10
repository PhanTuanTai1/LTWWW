using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai8.Models
{
    public class DonHang
    {
        private string tenKH;
        private string diaChi;
        private string maSoThue;
        private List<Pie> lstPie;
        public string TenKH
        {
            get
            {
                return tenKH;
            }

            set
            {
                tenKH = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string MaSoThue
        {
            get
            {
                return maSoThue;
            }

            set
            {
                maSoThue = value;
            }
        }

        public List<Pie> LstPie
        {
            get
            {
                return lstPie;
            }

            set
            {
                lstPie = value;
            }
        }
    }
}