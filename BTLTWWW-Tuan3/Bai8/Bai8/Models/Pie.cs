using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai8.Models
{
    public class Pie
    {
        private string namePie;
        private int soLuong;

        public string NamePie
        {
            get
            {
                return namePie;
            }

            set
            {
                namePie = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }
    }
}