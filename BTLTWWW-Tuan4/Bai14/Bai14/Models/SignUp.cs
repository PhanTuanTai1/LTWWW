using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bai14.Models
{
    public class SignUp
    {
        private string username;
        private string password;
        private string confirmPW;
        private string hoTen;
        private string gioiTinh;
        private string thuDienTu;
        private string phone;
        private DateTime ngaySinh;
        private string diaChi;
        private HttpPostedFileBase img;
        
        private string extend;
        [Required(ErrorMessage ="Vui lòng nhập tên đăng nhập")]
        [StringLength(maximumLength:1000,MinimumLength =6,ErrorMessage = "Tên đăng nhập phải có ít nhất 6 kí tự")]
        [Display(Name ="Tên đăng nhập")]
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }
        [Required(ErrorMessage ="Vui lòng nhập mật khẩu")]
        [StringLength(maximumLength: 1000, MinimumLength = 6, ErrorMessage = "Mật khẩu có tối đa 6 kí tự")]
        [Display(Name = "Mật khẩu")]
        [RegularExpression("^(?=.*[A-Za-z]{1}[0-9]{1}).{6,}$|^(?=.*[0-9]{1}[A-Za-z]{1}).{6,}$",ErrorMessage ="Mật khẩu phải có ít nhất 6 kí tự và phải có cả chữ và số")]
        
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        [Display(Name = "Họ tên")]
        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }
        [Required(ErrorMessage = "Vui lòng chọn giới tính")]
        [Display(Name = "Giới tính")]
        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }
        [Required(ErrorMessage ="Vui lòng nhập thư điện tử")]
        [Display(Name = "Thư điện tử")]
        [EmailAddress(ErrorMessage ="Thư điện tử không tồn tại")]
        public string ThuDienTu
        {
            get
            {
                return thuDienTu;
            }

            set
            {
                thuDienTu = value;
            }
        }
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [Display(Name = "Số điện thoại")]
        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }
        [Required(ErrorMessage = "Vui lòng nhập ngày sinh")]
        [Display(Name = "Ngày sinh")]
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
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        [Display(Name = "Địa chỉ")]
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
        [Display(Name = "Hình ảnh")]
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

        
        [Required(ErrorMessage ="Vui lòng xác nhận lại mật khẩu")]
        [Display(Name ="Nhập lại mật khẩu")]
        [Compare("Password",ErrorMessage ="Mật khẩu không trùng khớp")]
        public string ConfirmPW
        {
            get
            {
                return confirmPW;
            }

            set
            {
                confirmPW = value;
            }
        }
        [FileExtensions(Extensions = "jpg,png,gif", ErrorMessage = "Chỉ hổ trợ file hình ảnh .jpg, .png, .gif")]
        public string Extend
        {
            get
            {
                if (Img != null) return Img.FileName;
                return "temp.jpg";
            }

            set
            {
                extend = value;
            }
        }
    }
}