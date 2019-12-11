using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeSyDuy_ThietKeWeb.Models
{
    public class RegisterModel
    {
        [Key]
        public int ID { set; get; }

        [Display(Name= "Tên đăng nhập")]
        [Required(ErrorMessage = "Vui lòng nhập Tên đăng nhập")]
        public string Username { set; get; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Vui lòng nhập Mật khẩu")]
        [StringLength(20, MinimumLength = 6, ErrorMessage ="Độ dài ít nhất 6 kí tự")]
        public string Password { set; get; }

        [Display(Name ="Nhập lại mật khẩu")]
        [Compare("Password", ErrorMessage ="Nhập lại mật khẩu không chính xác!")]
        public string ConfirmPassword { set; get; }

        [Display(Name = "Họ và tên")]
        [Required(ErrorMessage = "Vui lòng nhập Họ và tên")]
        public string Name { set; get; }

        [Display(Name = "Giới tính")]
        public string Sex { set; get; }

        [Display(Name = "Ngày sinh")]
        [Required(ErrorMessage = "Vui lòng nhập Ngày sinh")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? NgaySinh { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Vui lòng nhập Email")]
        [EmailAddress(ErrorMessage = "Sai định dạng Email")]
        public string Email { set; get; }

        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Vui lòng nhập Số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^03([0-9]{8})+$", ErrorMessage = "Số điện thoại không đúng định dạng")]
        public string Phone { set; get; }
    }
}