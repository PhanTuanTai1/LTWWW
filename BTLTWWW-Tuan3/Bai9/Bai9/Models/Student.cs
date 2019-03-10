using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bai9.Models
{
    public class Student
    {
        private string id;
        private string name;
        private DateTime birthday;
        private string address;
        private string picUrl;
        private HttpPostedFileBase pic;

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
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string PicUrl
        {
            get
            {
                return picUrl;
            }

            set
            {
                picUrl = value;
            }
        }

        public HttpPostedFileBase Pic
        {
            get
            {
                return pic;
            }

            set
            {
                pic = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (obj is Student)
                {
                    Student s = (Student)obj;
                    if (s.Id == this.Id)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}