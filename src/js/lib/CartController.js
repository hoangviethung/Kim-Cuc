var CartController = CartController || {};

CartController = {
    model: {
        // This flag for set time out in case User change(plus and minus quantity) product's quantity in Cart Index
        isDelay: false,
    },
    init: function () {
        // Product detail page
        $(".add-cart").off('click').on('click', CartController.events.addToCart);
        // Cart page
        $(".cart").on('click', '.remove', CartController.events.removeFromCart);
        // Change quantity in quantity box by keyboard
        $(".quantity-input").on('keyup', '.quantity', CartController.events.changeQuantityProductInCart);
        $(".quantity-input").on('click', '.plus', CartController.events.addOneMore);
        $(".quantity-input").on('click', '.minus', CartController.events.minusOneMore);
        $("#btnGoToPayment").off('click').on('click', CartController.events.goToPayment);
        $('#applyCouponCode').on('click', CartController.events.applyCouponCode);
        // Payment address
        $(".add-new-address").click(CartController.events.getCity);
        $(".js-btn-edit-address").click(CartController.events.getCity);
        $("#ShippingCitySelectedValue").on('change', CartController.events.getDistrict);
    },
    events: {
        addToCart: function (event) {
            event.preventDefault();
            $.ajax({
                url: '/them-vao-gio-hang',
                type: 'POST',
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify({
                    pId: Number($(this).attr("data-id")),
                    quantity: Number($("input[name='quantity']").val()),
                    propertyId: Number($(this).attr("data-propertyid"))
                }),
                cache: false,
                success: function (response) {
                    if (response.Code == 200) {
                        $('.cart .nummber').text(response.Result.ItemsCount);
                        window.location.href = $('.cart a').attr('href');
                    }
                    else
                        alert(response.Message);

                },
                failure: function (errMsg) {
                    alert(errMsg);
                }
            });

            return false;
        },
        applyCouponCode: function (event) {
            event.preventDefault();
            // Get coupon code
            var couponCode = $('#couponCode').val();
            $.ajax({
                url: '/ap-dung-ma-khuyen-mai',
                type: 'POST',
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify({ couponCode: couponCode }),
                cache: false,
                success: function (result) {
                    if (result.Code == 200) {
                        // Cart Index: Change total price while adding recommend product on this page
                        $('.discount_amount').text(result.Result.discountAmount);
                        $('#tam_tinh').text(result.Result.totalTamTinh);
                        $('.actual_amount_total').text(result.Result.totalAmount);

                        alert(result.Message);
                    } else {
                        alert(result.Message);

                    }
                },
                failure: function (errMsg) {
                    alert(errMsg);
                }
            });
            return false;
        },
        goToPayment: function (event) {
            event.preventDefault();
            $.ajax({
                url: '/den-trang-thanh-toan',
                type: 'GET',
                contentType: "application/json; charset=utf-8",
                cache: false,
                success: function (response) {
                    if (response.Code == 200) {
                        // Redirect to get-payment-info page
                        window.location.href = "/thong-tin-thanh-toan";
                    } else {
                        if ($(".account-item").length > 0) {
                            $(".account-item .btn-main").click();
                        }
                        else {
                            alert(response.Message);
                        }
                    }

                },
                failure: function (errMsg) {
                    alert(errMsg);
                }
            });
            return false;
        },
        getCity: function () {
            var id = ($.isNumeric($(this).attr("data-city")) ? Number($(this).attr("data-city")) : 0);
            // Init district id
            $("#ShippingCitySelectedValue").attr("data-district", ($.isNumeric($(this).attr("data-district")) ? Number($(this).attr("data-district")) : 0));
            $.ajax({
                url: '/get-payment-city',
                type: 'GET',
                data: { id: id },
                contenttype: "application/json; charset=utf-8",
                cache: false,
                beforeSend: function () {
                    $('#ShippingCitySelectedValue').attr("disabled", true);
                    $('#ShippingCitySelectedValue').html('<option>Đang tải...</option>')
                },
                success: function (response) {
                    $('#ShippingCitySelectedValue').attr("disabled", false);
                    $('#ShippingCitySelectedValue').children().remove();
                    $("#ShippingCitySelectedValue").append($('<option></option>').val('').html('Chọn Tỉnh/Thành phố').attr('selected', true));
                    $.each(response, function (i, item) {
                        $("#ShippingCitySelectedValue").append($('<option></option>').val(item.Value).html(item.Text).attr('selected', item.Selected));
                    })

                    $("#ShippingCitySelectedValue").trigger("change");
                },
                failure: function (errmsg) {
                    alert(errmsg);
                }
            });
        },
        getDistrict: function () {
            var id = ($.isNumeric($(this).attr("data-district")) ? Number($(this).attr("data-district")) : 0);
            $.ajax({
                url: '/get-payment-district',
                type: 'GET',
                data: { cityId: Number($(this).val()), id: id },
                contenttype: "application/json; charset=utf-8",
                cache: false,
                beforeSend: function () {
                    $('#ShippingDistrictSelectedValue').attr("disabled", true);
                    $('#ShippingDistrictSelectedValue').html('<option>Đang tải...</option>')
                },
                success: function (response) {
                    $('#ShippingDistrictSelectedValue').attr("disabled", false);
                    $('#ShippingDistrictSelectedValue').children().remove();
                    $("#ShippingDistrictSelectedValue").append($('<option></option>').val('').html('Chọn Quận/Huyện').attr('selected', true));
                    $.each(response, function (i, item) {
                        $("#ShippingDistrictSelectedValue").append($('<option></option>').val(item.Value).html(item.Text).attr('selected', item.Selected));
                    })
                },
                failure: function (errmsg) {
                    alert(errmsg);
                }
            });
        },
        delayClick: function () {
            $(".quantity-input .plus").prop("disabled", "");
            $(".quantity-input .minus").prop("disabled", "");
            CartController.model.isDelay == false;
        },
        addOneMore: function (event) {
            event.preventDefault();
            if (CartController.model.isDelay == false) {
                CartController.model.isDelay == true;
                // Disable button for executing request to server
                $(this).attr("disabled", "disabled");
                // Get current quantity of product
                var input_val = $(this).parent('.quantity-input').find('input[name="quantity"]');

                var current_val = parseInt(input_val.val());
                // Set new quantity for product in Shopping cart
                if ($.isNumeric(current_val) && current_val > 0) {
                    var new_val = current_val + 1;
                } else { // Reset quantity if it lower than 0
                    var new_val = 1;
                }
                // Get product's Id
                var productId = $(this).attr("data-pid");
                // Get product's property Id
                var propertyId = $(this).attr("data-propertyid");
                // Execute request to server
                CartController.events.updateToCart(productId, propertyId, new_val);
                input_val.val(new_val);
                // Set delay time for server execute this request
                var time = 300;
                setTimeout(function () {
                    CartController.events.delayClick();
                }, time);
                CartController.model.isDelay == false;
            }

            return false;
        },
        minusOneMore: function (event) {
            event.preventDefault();
            if (CartController.model.isDelay == false) {
                CartController.model.isDelay == true;
                // Disable button for executing request to server
                $(this).attr("disabled", "disabled");
                // Get current quantity of product
                var input_val = $(this).parent('.quantity-input').find('input[name="quantity"]');
                var current_val = parseInt(input_val.val());
                // Set new quantity for product in Shopping cart
                if ($.isNumeric(current_val) && current_val > 1) {
                    var new_val = current_val - 1;
                } else { // Reset quantity if it lower than 0
                    var new_val = 1;
                }
                // Get product's Id
                var productId = $(this).attr("data-pid");
                // Get product's property Id
                var propertyId = $(this).attr("data-propertyid");
                // Execute request to server
                // Execute request to server
                CartController.events.updateToCart(productId, propertyId, new_val);
                input_val.val(new_val);
                // Set delay time for server execute this request
                var time = 300;
                setTimeout(function () {
                    CartController.events.delayClick();
                }, time);
                CartController.model.isDelay == false;
            }
            return false;
        },
        removeFromCart: function (event) {
            event.preventDefault();
            var productId = $(this).attr("data-pid");
            var propertyId = $(this).attr("data-propertyid");
            var divItem = $(this).parent().parent();
            // Check product's id is number
            if (productId != '' && $.isNumeric(productId)
                && propertyId != '' && $.isNumeric(propertyId)) {
                $.ajax({
                    url: '/xoa-khoi-gio-hang',
                    type: 'POST',
                    contentType: "application/json; charset=utf-8",
                    data: JSON.stringify({ pId: Number(productId), propertyId: Number(propertyId) }),
                    cache: false,
                    success: function (response) {
                        if (response.Code == 200) {
                            // Header shopping cart
                            $(".cart .nummber").text(response.Result.ItemsCount);
                            $("#quantity-product").text(response.Result.ItemsCount + " ");
                            // Cart Index
                            $(".cart-summary p").eq(0).find("span").eq(1).html(response.Result.Total + " đ");
                            if ($(".cart-summaryt p").eq(1).find("span").eq(1).length > 0) {
                                $(".cart-summary p").eq(1).find("span").eq(1).html(response.Result.DiscountAmount);
                            }
                            $(".quantity-product").html(response.Result.ItemsCount);
                            $(".cart-summary .total").html(response.Result.AfterDiscount + " đ");

                            // remove html
                            divItem.remove();
                            $("#type-product").text(($(".cart tr").length - 1) + " ");
                        }
                    },
                    failure: function (errMsg) {
                        alert(errMsg);
                    }
                });
            }

            return false;
        },
        changeQuantityProductInCart: function (event) {
            event.preventDefault();
            var input_val = $(this);
            var current_val = parseInt(input_val.val());
            if ($.isNumeric(input_val.val()) && current_val > 0) {
                if (current_val > 500) {
                    current_val = 500;
                    input_val.val(current_val);
                }
            } else {
                current_val = 1;
                input_val.val(current_val);
            }
            var productId = $(this).attr("data-pid");
            var propertyId = $(this).attr("data-propertyid");
            CartController.events.updateToCart(productId, propertyId, current_val);
            return false;
        },
        updateToCart: function (productId, propertyId, quantity) {
            // Check product's Id and quantity is number
            if (productId != '' && $.isNumeric(productId)
                && quantity != '' && $.isNumeric(quantity)
                && propertyId != '' && $.isNumeric(propertyId)) {
                $.ajax({
                    url: '/cap-nhat-gio-hang',
                    type: 'POST',
                    contentType: "application/json; charset=utf-8",
                    data: JSON.stringify({ pId: productId, propertyId: propertyId, quantity: quantity }),
                    cache: false,
                    success: function (response) {
                        if (response.Code == 200) {
                            // Header shopping cart
                            $(".cart .nummber").text(response.Result.ItemsCount);
                            $("#quantity-product").text(response.Result.ItemsCount + " ");
                            // Cart Index
                            $(".cart-summary p").eq(0).find("span").eq(1).html(response.Result.Total + " đ");
                            if ($(".cart-summaryt p").eq(1).find("span").eq(1).length > 0) {
                                $(".cart-summary p").eq(1).find("span").eq(1).html(response.Result.DiscountAmount);
                            }
                            $(".quantity-product").html(response.Result.ItemsCount);
                            $(".cart-summary .total").html(response.Result.AfterDiscount + " đ");
                        }
                    },
                    failure: function (errMsg) {
                        alert(errMsg);
                    }
                });
            }
        },
    }
}

$(document).ready(function () {
    CartController.init();
});