using Model.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeSyDuy_ThietKeWeb.Models
{
    public class UserChangePasswordModel
    {
        [Required(ErrorMessage = "Mật khẩu cũ không được trống.")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Mật khẩu mới không được trống.")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Nhập lại mật khẩu mới không được trống.")]
        [Compare("NewPassword", ErrorMessage = "Nhập lại mật khẩu mới không đúng.")]
        public string ConfirmNewPassword { get; set; }
    }
}