using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai6.Models
{
    public class Hoa
    {
        private int idHoa;
        private string tenHoa;
        private string extend;

        public int IdHoa
        {
            get
            {
                return idHoa;
            }

            set
            {
                idHoa = value;
            }
        }

        public string TenHoa
        {
            get
            {
                return tenHoa;
            }

            set
            {
                tenHoa = value;
            }
        }

        public string Extend
        {
            get
            {
                return extend;
            }

            set
            {
                extend = value;
            }
        }
    }
}