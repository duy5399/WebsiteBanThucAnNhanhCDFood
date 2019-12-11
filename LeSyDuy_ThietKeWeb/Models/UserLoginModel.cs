using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeSyDuy_ThietKeWeb.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage = "Mời bạn nhập Tên tài khoản")] //trường bắt buộc phải nhập Tên Đăng nhập
        public string TenDN { set; get; }

        [Required(ErrorMessage = "Mời bạn nhập Mật khẩu")] //trường bắt buộc phải nhập Mật khẩu
        public string MatKhau { set; get; }

        public bool RememberMe { set; get; }
    }
}