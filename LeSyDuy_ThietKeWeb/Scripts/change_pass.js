var check = {
    init: function () {
        check.regEvents();
    },
    regEvents: function () {
        $('#btnChangePass').off('click').on('click', function () {
            var mkmoi = document.getElementById("matkhaumoitxt").value;
            var mkmoi2 = document.getElementById("matkhaumoi2txt").value;
            if (mkmoi != mkmoi2) {
                alert("Nhập lại mật khẩu mới không đúng!");
            }
        });
    }
}
check.init();