using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai1.Models
{
    public class Cal
    {
        private double a;
        private double b;
        private string op;

        public double A
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }

        public double B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
        }

        public string Op
        {
            get
            {
                return op;
            }

            set
            {
                op = value;
            }
        }
    }
}