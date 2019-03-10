using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bai15.Models
{
    public class SignUp
    {
        private string email;
        private string confirmEmail;
        private int age;
        private double salary;
        private string creditCard;
        private string url;
        private HttpPostedFileBase photo;
        private string photoEx;
        private string motoNumber;
        private string description;
        [Required(ErrorMessage ="Vui lòng nhập email")]
        [EmailAddress(ErrorMessage ="Sai định dạng email")]
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        [Required(ErrorMessage = "Vui lòng nhập xác nhận email")]
        [Compare("Email",ErrorMessage ="Email xác nhận không trùng khớp")]
        public string ConfirmEmail
        {
            get
            {
                return confirmEmail;
            }

            set
            {
                confirmEmail = value;
            }
        }
        [Required(ErrorMessage ="Vui lòng nhập tuổi")]
        [RegularExpression("^/d$",ErrorMessage ="Tuổi phải là số")]
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        public string CreditCard
        {
            get
            {
                return creditCard;
            }

            set
            {
                creditCard = value;
            }
        }

        public string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
            }
        }

        public HttpPostedFileBase Photo
        {
            get
            {
                return photo;
            }

            set
            {
                photo = value;
            }
        }

        public string PhotoEx
        {
            get
            {
                return photoEx;
            }

            set
            {
                photoEx = value;
            }
        }

        public string MotoNumber
        {
            get
            {
                return motoNumber;
            }

            set
            {
                motoNumber = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }
    }
}