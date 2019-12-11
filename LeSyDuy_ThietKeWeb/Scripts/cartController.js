var cart = {
    init: function () {
        cart.regEvents();
    },
    regEvents: function () {
        $('#btnContinue').off('click').on('click', function () {
            window.location.href = '/thuc-don';
        });

        $('#btnPayment').off('click').on('click', function () {
            window.location.href = '/thanh-toan';
        });

        $('#btnUpdate').off('click').on('click', function () {
            var listMonan = $('.qty');
            var cartList = [];
            $.each(listMonan, function (i, item) {
                cartList.push({
                    SoLuong: $(item).val(), 
                    MonAn: {
                        MaMonAn: $(item).data('id') 
                    }
                });
            });

            $.ajax({
                url: '/Cart/Update',
                data: { cartModel: JSON.stringify(cartList) },
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/gio-hang";
                    }
                }
            })
        });

        $('#btnDeleteAll').off('click').on('click', function () {         
            $.ajax({
                url: '/Cart/DeleteAll',
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/gio-hang";
                    }
                }
            })
        }); 

        $('.btn-delete').off('click').on('click', function () {
            $.ajax({
                data: { MaMonAn: $(this).data('id') },
                url: '/Cart/Delete',
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/gio-hang";
                    }
                }
            })
        }); 
    }
}
cart.init();