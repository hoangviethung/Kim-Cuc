﻿module.exports = () => {
	var CartController = CartController || {};

	CartController = {
		model: {
			// This flag for set time out in case User change(plus and minus quantity) product's quantity in Cart Index
			isDelay: false,
		},
		init: function() {
			const bodySectionCartPage = $('.cart-list-page');
			// NÚT THÊM VÀO GIỎ HÀNG
			const addCart = $('.add-cart');
			// NÚT THÊM SỐ LƯỢNG SẢN PHẨM +1
			const upQuantity = $('.upQuantity');
			// NÚT GIẢM SỐ LƯỢNG SẢN PHẨM -1
			const downQuantity = $('.downQuantity');
			// NÚT NHẤN ÁP DỤNG MÃ GIẢM GIÁ
			const couponCode = $('#applyCouponCode');
			// NÚT ĐI ĐẾN TRANG THANH TOÁN
			const goToPayment = $("#goToPayment");
			// BLOCK SỐ LƯỢNG SẢN PHẨM
			const quantityInput = $(".quantity-input");
			// NÚT XÓA 1 SẢN PHẢM KHỎI GIỎ HÀNG
			const removeItemCart = $('.remove-cart');

			// THÊM VÀO GIỎ HÀNG
			addCart.off('click').on('click', CartController.events.addToCart);
			// TĂNG SỐ LƯỢNG SẲN PHẨM
			upQuantity.on('click', CartController.events.upQuantity);
			// GIẢM SÓ LƯỢNG SẢN PHẨM
			downQuantity.on('click', CartController.events.downQuantity);
			// MÃ GIẢM GIÁ
			couponCode.on('click', CartController.events.applyCouponCode);
			// THAY ĐỔI SỐ LƯỢNG SẢN PHẨM TRONG TRANG GIỎ HÀNG
			quantityInput.on('keyup', '.quantity-cart', CartController.events.changeQuantityProductInCart);
			// XÓA SẢN PHẨM KHỎI GIỎ HÀNG
			removeItemCart.on('click', CartController.events.removeFromCart);
			// ĐẾN TRANG THANH TOÁN (TÙY DỰ ÁN)
			goToPayment.off('click').on('click', CartController.events.goToPayment);


			// PHẦN THANH TOÁN (CHƯA LÀM ĐẾN)
			$(".add-new-address").click(CartController.events.getCity);
			$(".js-btn-edit-address").click(CartController.events.getCity);
			$("#ShippingCitySelectedValue").on('change', CartController.events.getDistrict);
		},
		events: {
			// THÊM VÀO GIỎ HÀNG
			addToCart: function(e) {
				e.preventDefault();
				// URL
				const url = $(this).attr('data-url');
				// MÃ SẢN PHẨM
				const dataId = $(this).attr("data-pid");
				// SỐ LƯỢNG
				const quantity = $("input[name='quantity']").val();
				// THUỘC TÍNH
				const propertyId = $(this).attr("data-propertyid");
				// SỐ TRÊN GIỎ HÀNG THANH MENU
				const headerCartNumber = ('#header-cart-number');

				$.ajax({
					url: url,
					type: 'POST',
					contentType: "application/json; charset=utf-8",
					data: JSON.stringify({
						pId: Number(dataId),
						quantity: Number(quantity),
						propertyId: Number(propertyId)
					}),
					cache: false,
					success: function(res) {
						if (res.Code == 200) {
							// TRUYỂN KẾT QUẢ VÀO SỐ LƯỢNG GIỎ HÀNG TRÊN THANH MENU
							headerCartNumber.text(res.Result.ItemCount);
						} else
							alert(res.Message);
					},
					failure: function(errMsg) {
						alert(errMsg);
					}
				});
				return false;
			},
			// TĂNG SỐ LƯỢNG SẲN PHẨM
			upQuantity: function(e) {
				e.preventDefault();
				if (CartController.model.isDelay == false) {
					CartController.model.isDelay == true;
					// Disable button for executing request to server
					$(this).attr("disabled", "disabled");
					// INPUT SỐ LƯỢNG SẢN PHẨM
					const input_val = $(this).parents('.quantity-input').find('.quantity-cart[name="quantity"]');
					// LẤY GIÁ TRỊ CŨ CỦA INPUT
					let current_val = parseInt(input_val.val());
					// GIÁ TRỊ MỚI
					let new_val = ++current_val;
					// ĐIỀU KIỆN SỐ LƯỢNG
					if ($.isNumeric(current_val) && current_val > 0) {
						// THÕA MÃN THÌ +1
						new_val
					} else {
						// KHÔNG THÕA MÃN THÌ TRỞ VỀ MẶC ĐỊNH 1
						new_val = 1;
					}
					// MÃ SẢN PHẨM
					const productId = $(this).attr("data-pid");
					// THUỘC TÍNH SẢN PHẨM
					const propertyId = $(this).attr("data-propertyid");
					// ĐỊA CHỈ URL UPDATE
					const urlUpdate = $(this).attr('data-url-update');
					// TRUYỀN SÓ LƯỢNG SẢN PHẨM VÀO INPUT
					input_val.val(new_val);
					// GỌI HÀM UPDATE GIỎ HÀNG TRUYỀN 4 THÔNG SỐ VÀO (MÃ SẢN PHẨM, THUỘC TÍNH, SỐ LƯỢNG, ĐỊA CHỈ URL UPDATE)
					CartController.events.updateToCart(productId, propertyId, new_val, urlUpdate);
					// CÀI ĐẶT THỜI GIAN RESQUEST LÊN SEVER
					let time = 300;
					setTimeout(function() {
						CartController.events.delayClick();
					}, time);
					CartController.model.isDelay == false;
				}

				return false;
			},
			// GIẢM SỐ LƯỢNG SẢN PHẨM
			downQuantity: function(e) {
				e.preventDefault();
				if (CartController.model.isDelay == false) {
					CartController.model.isDelay == true;
					// INPUT SỐ LƯỢNG SẢN PHẨM
					const input_val = $(this).parents('.quantity-input').find('.quantity-cart[name="quantity"]');
					// LẤY GIÁ TRỊ CŨ CỦA INPUT
					let current_val = parseInt(input_val.val());
					// GIÁ TRỊ MỚI
					let new_val = --current_val;
					// ĐIỀU KIỆN SỐ LƯỢNG
					if ($.isNumeric(current_val) && current_val > 0) {
						// THÕA MÃN THÌ -1
						new_val
					} else {
						// KHÔNG THÕA MÃN THÌ TRỞ VỀ MẶC ĐỊNH 1
						new_val = 1;
					}
					// MÃ SẢN PHẨM
					const productId = $(this).attr("data-pid");
					// THUỘC TÍNH SẢN PHẨM
					const propertyId = $(this).attr("data-propertyid");
					// TRUYỀN SÓ LƯỢNG SẢN PHẨM VÀO INPUT
					input_val.val(new_val);
					// ĐỊA CHỈ URL UPDATE
					const urlUpdate = $(this).attr('data-url-update');
					// GỌI HÀM UPDATE GIỎ HÀNG TRUYỀN 4 THÔNG SỐ VÀO (MÃ SẢN PHẨM, THUỘC TÍNH, SỐ LƯỢNG, ĐỊA CHỈ URL UPDATE)
					CartController.events.updateToCart(productId, propertyId, new_val, urlUpdate);
					// CÀI ĐẶT THỜI GIAN RESQUEST LÊN SEVER
					let time = 300;
					setTimeout(function() {
						CartController.events.delayClick();
					}, time);
					CartController.model.isDelay == false;
				}

				return false;
			},
			// NHẬP MÃ GIẢM GIÁ
			applyCouponCode: function(e) {
				e.preventDefault();
				// Get coupon code
				const url = $(this).attr('data-url');
				// MÃ GIẢM GIÁ
				const valCouponCode = $('#couponCode').val();
				// SỐ TIỀN ĐƯỢC GIẢM
				const discountAmount = $('#discount_amount');
				// TỐNG SỐ TIỀN CẦN THANH TOÁN (TIỀN CUỐI CÙNG)
				const actualAmountTotal = $('#actual_amount_total');
				// GIÁ TIỀN TÍNH TẠM
				const tempPrice = $('#temp_price');
				$.ajax({
					url: url,
					type: 'POST',
					contentType: "application/json; charset=utf-8",
					data: JSON.stringify({
						valCouponCode: valCouponCode
					}),
					cache: false,
					success: function(res) {
						if (res.Code == 200) {
							// SỐ TIỀN ĐƯỢC GIẢM
							discountAmount.text(res.Result.discountAmount);
							// GIÁ TIỀN TÍNH TẠM
							tempPrice.text(res.Result.totalTamTinh);
							// TỐNG SỐ TIỀN CẦN THANH TOÁN (TIỀN CUỐI CÙNG)
							actualAmountTotal.text(res.Result.totalAmount);
						} else {
							alert(res.Message);
						}
					},
					failure: function(errMsg) {
						alert(errMsg);
					}
				});
				return false;
			},
			// THAY ĐỔI SỐ LƯỢNG SẢN PHẨM TRONG TRANG GIỎ HÀNG
			changeQuantityProductInCart: function(e) {
				e.preventDefault();
				const input_val = $(this);
				let current_val = parseInt(input_val.val());
				if ($.isNumeric(input_val.val()) && current_val > 0) {
					if (current_val > 500) {
						current_val = 500;
						input_val.val(current_val);
					}
				} else {
					current_val = 1;
					input_val.val(current_val);
				}
				const productId = $(this).attr("data-pid");
				const propertyId = $(this).attr("data-propertyid");
				CartController.events.updateToCart(productId, propertyId, current_val);
				return false;
			},
			// XÓA SẢN PHẨM KHỎI GIỎ HÀNG
			removeFromCart: function(e) {
				e.preventDefault();
				const url = $(this).attr('data-url');
				const productId = $(this).attr("data-pid");
				const propertyId = $(this).attr("data-propertyid");
				const itemRemove = $(this).parents('.cart-item');
				const headerCartNumber = ('#header-cart-number');
				const quantityProduct = $("#quantity-product");
				// Check product's id is number
				if (productId != '' && $.isNumeric(productId) &&
					propertyId != '' && $.isNumeric(propertyId)) {
					$.ajax({
						url: url,
						type: 'POST',
						contentType: "application/json; charset=utf-8",
						data: JSON.stringify({
							pId: Number(productId),
							propertyId: Number(propertyId)
						}),
						cache: false,
						success: function(res) {
							if (res.Code == 200) {
								// SỐ LƯỢNG GIỎ HÀNG TRONG MENU
								headerCartNumber.text(res.Result.ItemCount);
								// SỐ LƯỢNG SẢN PHẨM Ở TRANG GIỎ HÀNG
								quantityProduct.text(res.Result.ItemCount + " ");
								// XÓA SẢN PHẨM ĐƯỢC CLICK VÀO
								itemRemove.remove();
							}
						},
						failure: function(errMsg) {
							alert(errMsg);
						}
					});
				} else {
					console.log('Không thể xóa');
				}

				return false;
			},
			// ĐẾN TRANG THANH TOÁN
			goToPayment: function(e) {
				e.preventDefault();
				const url = $(this).attr('data-url');
				const urlPagePaymen = $(this).attr('data-url-paymen');
				const urlPageCart = $(this).attr('data-url-page-cart');
				$.ajax({
					url: url,
					type: 'GET',
					contentType: "application/json; charset=utf-8",
					cache: false,
					success: function(res) {
						if (res.Code == 200) {
							// Redirect to get-payment-info page
							window.location.href = urlPagePaymen;
						} else {
							if ($(".account-item").length > 0) {
								window.location.href = urlPageCart;
							} else {
								alert(res.Message);
							}
						}

					},
					failure: function(errMsg) {
						alert(errMsg);
					}
				});
				return false;
			},
			// CẬP NHẬT GIỎ HÀNG
			updateToCart: function(productId, propertyId, quantity, urlUpdate) {
				// Check product's Id and quantity is number
				if (productId != '' && $.isNumeric(productId) &&
					quantity != '' && $.isNumeric(quantity) &&
					propertyId != '' && $.isNumeric(propertyId)) {
					$.ajax({
						url: urlUpdate,
						type: 'POST',
						contentType: "application/json; charset=utf-8",
						data: JSON.stringify({
							pId: productId,
							propertyId: propertyId,
							quantity: quantity
						}),
						cache: false,
						success: function(res) {
							const headerCartNumber = $('#header-cart-number');
							const headerQuantityProduct = $("#header-quantity-product");
							const headerActualAmountTotal = $('#header-actual_amount_total');
							if (res.Code == 200) {
								// CẬP NHẬT GIỎ HÀNG TẠI THANH MENU
								headerCartNumber.text(res.Result.ItemCount);
								headerQuantityProduct.text(res.Result.ItemCount + " ");
								headerActualAmountTotal.html(response.Result.AfterDiscount + " đ");
							} else {
								console.log('Giỏ hàng không được thay đổi');
							}
						},
						failure: function(errMsg) {
							alert(errMsg);
						}
					});
				}
			},





			// PHẦN THANH TOÁN (CHƯA LÀM ĐẾN)
			getCity: function() {
				var id = ($.isNumeric($(this).attr("data-city")) ? Number($(this).attr("data-city")) : 0);
				// Init district id
				$("#ShippingCitySelectedValue").attr("data-district", ($.isNumeric($(this).attr("data-district")) ? Number($(this).attr("data-district")) : 0));
				$.ajax({
					url: '/get-payment-city',
					type: 'GET',
					data: {
						id: id
					},
					contenttype: "application/json; charset=utf-8",
					cache: false,
					beforeSend: function() {
						$('#ShippingCitySelectedValue').attr("disabled", true);
						$('#ShippingCitySelectedValue').html('<option>Đang tải...</option>')
					},
					success: function(response) {
						$('#ShippingCitySelectedValue').attr("disabled", false);
						$('#ShippingCitySelectedValue').children().remove();
						$("#ShippingCitySelectedValue").append($('<option></option>').val('').html('Chọn Tỉnh/Thành phố').attr('selected', true));
						$.each(response, function(i, item) {
							$("#ShippingCitySelectedValue").append($('<option></option>').val(item.Value).html(item.Text).attr('selected', item.Selected));
						})

						$("#ShippingCitySelectedValue").trigger("change");
					},
					failure: function(errmsg) {
						alert(errmsg);
					}
				});
			},

			getDistrict: function() {
				var id = ($.isNumeric($(this).attr("data-district")) ? Number($(this).attr("data-district")) : 0);
				$.ajax({
					url: '/get-payment-district',
					type: 'GET',
					data: {
						cityId: Number($(this).val()),
						id: id
					},
					contenttype: "application/json; charset=utf-8",
					cache: false,
					beforeSend: function() {
						$('#ShippingDistrictSelectedValue').attr("disabled", true);
						$('#ShippingDistrictSelectedValue').html('<option>Đang tải...</option>')
					},
					success: function(response) {
						$('#ShippingDistrictSelectedValue').attr("disabled", false);
						$('#ShippingDistrictSelectedValue').children().remove();
						$("#ShippingDistrictSelectedValue").append($('<option></option>').val('').html('Chọn Quận/Huyện').attr('selected', true));
						$.each(response, function(i, item) {
							$("#ShippingDistrictSelectedValue").append($('<option></option>').val(item.Value).html(item.Text).attr('selected', item.Selected));
						})
					},
					failure: function(errmsg) {
						alert(errmsg);
					}
				});
			},

			delayClick: function() {
				$(".quantity-input .plus").prop("disabled", "");
				$(".quantity-input .minus").prop("disabled", "");
				CartController.model.isDelay == false;
			},
		}
	}

	$(document).ready(function() {
		CartController.init();
	});
};