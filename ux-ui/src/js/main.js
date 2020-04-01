import Cookie from "./lib/Cookie";
import Loading from "./lib/Loading";
import Tab from "./lib/Tab";
import CartController from "./lib/CartController";
import CommonController from "./lib/CommonController";

// HÀM SET CHIỀU CAO CỦA BORDER !!!
const transitionTime = 300;
const header = document.querySelector('header');
const transitionEffect = `${transitionTime/1000}s all ease-in-out`;
header.style.transition = transitionEffect;
$('.block-logo .triangle').css('transition', transitionEffect);

const setBorder = () => {
	setTimeout(() => {
		const width = $('header .block-logo').width();
		const height = $('header .block-logo').height();
		if ($('header').hasClass('scrolled')) {
			$('.triangle').css({
				'left': '-100%',
			})
		} else {
			$('.triangle').css({
				'left': '0',
				'border-right': width + "px solid transparent",
				'border-top': height + "px solid #ffffff",
			})
		}
	}, transitionTime);
}

// HÀM SET PADDING CHO NAV LIST ĐỂ BLOCK CART RỚT XUỐNG !!!
const paddingRightNavList = () => {
	const widthBlockCart = $('.block-cart').outerWidth();
	const navList = $('header .bottom-header .nav-list');
	if ($('header').hasClass('scrolled')) {
		navList.css('padding-right', widthBlockCart + 30);
	} else {
		navList.css('padding-right', 'unset')
	}
}

// HÀM ADD CLASS
const addClassScroll = () => {
	const heightHeader = header.offsetHeight;
	if (window.pageYOffset >= heightHeader) {
		document.querySelector('header').classList.add('scrolled');
	} else {
		document.querySelector('header').classList.remove('scrolled');
	}
}

// HEADER HERE !!!
const activeHeaderWhenScroll = () => {
	if ($(window).width() > 1200) {
		setBorder();
		paddingRightNavList();
		addClassScroll();
	}
}

// THAY ĐỔI MENU KHI MÀN HÌNH TẦM 1200PX -> 1024PX
const activeMenuOnSmallDesktop = () => {
	if ($(window).width() <= 1200 && $(window).width() > 1024) {
		document.querySelector('header').classList.add('scrolled');
		const navList = $('header .bottom-header .nav-list');
		navList.css('padding-right', '130px');
	}
}

const toggleMenuMobile = () => {
	$('.toggle-menu.mobile').on('click', function() {
		$(this).toggleClass('active');
		$('.bottom-header').toggleClass('active');
		$('body').toggleClass('disabled')
		$('#overlay').toggleClass('active');
		$('.main-nav .sub-menu-lv1').removeClass('active');
	});

	$('#overlay').on('click', function() {
		$(this).removeClass('active');
		$('body').removeClass('disabled')
		$('.bottom-header').removeClass('active');
		$('.toggle-menu').removeClass('active');
		$('.main-nav .sub-menu-lv1').removeClass('active');
	})
}

const initializationClassSubMenu = () => {
	const itemHasSub = $('header .main-nav .nav-list .nav-item').children('.nav-list');
	itemHasSub.addClass('sub-menu-lv1');
	itemHasSub.parents('.nav-item').addClass('has-sub');
}

const SubMenuMobile = () => {
	if ($(window).width() <= 1024) {
		$('.main-nav .nav-list .has-sub').on('click', function(e) {
			e.stopPropagation();
			$(e.currentTarget).children('.sub-menu-lv1').addClass('active');
		});

		$('.main-nav .nav-list .has-sub .back').on('click', function(e) {
			e.stopPropagation();
			$(e.currentTarget).closest('.sub-menu-lv1').removeClass('active');
		});
	}
}

const toggleCartMenu = () => {
	$('header .block-cart .block-text-icon').on('click', function() {
		$(this).siblings('.cart-panel').toggleClass('open');
	});
}

const checkPageToAddClassMainSlider = () => {
	if (!$('main').find('#js-page-verify').hasClass('index-page')) {
		$('.main-banner').addClass('small-banner');
	}
}

// SLIDER HERE !!!
const mainSlider = () => {
	var swiper = new Swiper('.slider-main-banner .swiper-container', {
		loop: true,
		speed: 1000,
		autoplay: {
			delay: 3000,
			disableOnInteraction: false,
		},
		grabCursor: true,
		watchSlidesProgress: true,
		mousewheelControl: true,
		keyboardControl: true,
		pagination: {
			el: '.slider-main-banner .swiper-pagination',
			type: 'bullets',
			clickable: true,
		},
		on: {
			progress: function() {
				var swiper = this;
				for (var i = 0; i < swiper.slides.length; i++) {
					var slideProgress = swiper.slides[i].progress;
					var innerOffset = swiper.width * 0.5;
					var innerTranslate = slideProgress * innerOffset;
					swiper.slides[i].querySelector(".swiper-inner").style.transform =
						"translate3d(" + innerTranslate + "px, 0, 0)";
				}
			},
			touchStart: function() {
				var swiper = this;
				for (var i = 0; i < swiper.slides.length; i++) {
					swiper.slides[i].style.transition = "";
				}
			},
			setTransition: function(speed) {
				var swiper = this;
				for (var i = 0; i < swiper.slides.length; i++) {
					swiper.slides[i].style.transition = speed + "ms";
					swiper.slides[i].querySelector(".swiper-inner").style.transition =
						speed + "ms";
				}
			}
		}
	})
}

const productDetailSlider = () => {
	var thumbnail = new Swiper('.slider-product-detail .thumbnail-image .swiper-container', {
		spaceBetween: 15,
		slidesPerView: 2,
		loop: true,
		observer: true,
		observeParents: true,
		slideToClickedSlide: true,
		autoplay: {
			delay: 3000,
			disableOnInteraction: false,
		},
		navigation: {
			nextEl: '.thumbnail-image .swiper-button-next',
			prevEl: '.thumbnail-image .swiper-button-prev',
		},
		breakpoints: {
			320: {
				direction: 'vertical',
				slidesPerView: 2,
			},
			575: {
				direction: 'horizontal',
				slidesPerView: 3,
				spaceBetween: 10,
			},
			1025: {
				direction: 'vertical',
				slidesPerView: 3,
			}
		},
	});

	var review = new Swiper('.slider-product-detail .review-image .swiper-container', {
		effect: 'fade',
		fadeEffect: {
			crossFade: true,
		},
		autoplay: {
			delay: 3000,
			disableOnInteraction: false,
		},
		loop: true,
		simulateTouch: false,
		loopedSlides: 3,
		thumbs: {
			swiper: thumbnail,
		},
		navigation: {
			nextEl: '.thumbnail-image.swiper-button-next',
			prevEl: '.thumbnail-image.swiper-button-prev',
		}
	});
}

const productOtherSlider = () => {
	var swiper = new Swiper('.slider-products-other .swiper-container', {
		slidesPerView: 2,
		spaceBetween: 10,
		loop: true,
		speed: 500,
		simulateTouch: false,
		autoplay: {
			delay: 2000,
			disableOnInteraction: false,
		},
		navigation: {
			nextEl: '.slider-products-other .swiper-button-next',
			prevEl: '.slider-products-other .swiper-button-prev',
		},
		breakpoints: {
			768: {
				slidesPerView: 4,
				spaceBetween: 10,
			},
			1024: {
				slidesPerView: 4,
				spaceBetween: 10,
			},
			1200: {
				slidesPerView: 5,
				spaceBetween: 16,
			}
		},
	})
}

const setHeightThumbnailSliderProductDetail = () => {
	if (window.innerWidth >= 1025 || window.innerWidth <= 575) {
		const heightReview = $('.slider-product-detail .review-image img').height();
		$('.thumbnail-image').css('height', heightReview);
	}
}

// SLIDER NHÀ PHÂN PHỐI !!!
const distributorSlider = () => {
	var swiper = new Swiper('.slider-distributor .swiper-container', {
		slidesPerView: 4,
		spaceBetween: 10,
		loop: true,
		speed: 500,
		simulateTouch: false,
		autoplay: {
			delay: 2000,
			disableOnInteraction: false,
		},
		navigation: {
			nextEl: '.slider-distributor .swiper-button-next',
			prevEl: '.slider-distributor .swiper-button-prev',
		},
		breakpoints: {
			1200: {
				slidesPerView: 5,
				spaceBetween: 29,
			}
		},
	})
}

// SLIDER KHÁCH HÀNG !!!
const customerSlider = () => {
	var swiper = new Swiper('.slider-customer .swiper-container', {
		slidesPerView: 1,
		spaceBetween: 0,
		loop: true,
		speed: 500,
		simulateTouch: false,
		autoplay: {
			delay: 2000,
			disableOnInteraction: false,
		},
		navigation: {
			nextEl: '.slider-customer .swiper-button-next',
			prevEl: '.slider-customer .swiper-button-prev',
		},
		breakpoints: {
			575: {
				slidesPerView: 2,
				spaceBetween: 10,
			},
			900: {
				slidesPerView: 3,
				spaceBetween: 10,
			},
			1440: {
				slidesPerView: 5,
				spaceBetween: 16,
			}
		},
	})
}

const setHeightOverFolowBySomeElement = (selector) => {
	$(selector).each(function() {
		const heightGet = $(this).find('[data-getHeight]').innerHeight();
		const heightSet = $(this).find('[data-setHeight]');
		const responsive = heightSet.attr('data-setHeight');
		if (window.innerWidth > responsive) {
			heightSet.css('max-height', heightGet)
		}
	})
}

const rangeSliderPrice = () => {
	let min_price = Number($("#slider-range").attr('data-min'));
	let max_price = Number($("#slider-range").attr('data-max'));
	const pathname = window.location.pathname;
	const origin = window.location.origin;
	const url = origin + pathname;

	const getBrand = e => {
		let brand;
		$('.brand .check-box [name="brand"]').each(function() {
			if ($(this)[0].checked) {
				brand = $(this)[0].value;
			}
		})
		return brand;
	}

	const getUrl = (min, max) => {
		let fromParam = `fromPrice=${min}`;
		let toParam = `toPrice=${max}`;
		let brandParam;
		if (getBrand().length > 0) {
			brandParam = `brands=${getBrand()}`
			return `${url}?${fromParam}&${toParam}&${brandParam}`
		} else {
			brandParam = null;
			return `${url}?${fromParam}&${toParam}`
		}
	}

	const ajaxFilterProduct = (url) => {
		$.ajax({
			type: "GET",
			url: url,
			beforeSend: function() {
				$('.list-product .list-item').css({
					'opacity': '.2',
					'pointer-events': 'none'
				})
			},
			success: function(res) {
				const pagination = $(res).find('.block-list-product .pagination');
				const listProduct = $(res).find('.list-product .list-item');
				$('.list-product .list-item').html(listProduct.html());
				$('.block-list-product .pagination').html(pagination.html());
				if (pagination.html()) {
					$('.block-list-product .pagination').html(pagination.html());
				} else {
					$('.block-list-product .pagination').html('');
				}
			},
			complete: function() {
				$('.list-product .list-item').css({
					'opacity': '1',
					'pointer-events': 'initial'
				})
				window.history.pushState({}, '', url);
			}
		});
	}

	$('.brand .check-box [name="brand"]').on('change', () => {
		let minFinal = Number($("#value-text").attr('data-min-html'))
		let maxFinal = Number($("#value-text").attr('data-max-html'))
		const urlRequest = getUrl(minFinal, maxFinal);
		ajaxFilterProduct(urlRequest);
	})

	if (min_price !== max_price) {
		let curMinPrice = Number($("#slider-range").attr('data-current-min'))
		let curMaxPrice = Number($("#slider-range").attr('data-current-max'))
		$("#value-text").attr('data-min-html', curMinPrice);
		$("#value-text").attr('data-max-html', curMaxPrice);
		$("#slider-range").slider({
			range: true,
			min: min_price,
			max: max_price,
			values: [curMinPrice, curMaxPrice],
			slide: function(event, ui) {
				$("#amount").val(ui.values[0] + " - " + ui.values[1]);
				$("#value-text").html(ui.values[0] + " đ - " + ui.values[1] + " đ");
				$("#value-text").attr('data-min-html', ui.values[0]);
				$("#value-text").attr('data-max-html', ui.values[1]);
			},
			stop: function(event, ui) {
				const minFinal = $("#amount").val(ui.values[0]).val();
				const maxFinal = $("#amount").val(ui.values[1]).val();
				const urlRequest = getUrl(minFinal, maxFinal);
				ajaxFilterProduct(urlRequest);
			},
			create: function(event, ui) {

			}
		});
		$("#amount").val($("#slider-range").slider("values", 0) + " - " + $("#slider-range").slider("values", 1));
		$("#value-text").html($("#slider-range").slider("values", 0) + "đ - " + $("#slider-range").slider("values", 1) + "đ");
	} else {
		$('.block-filter .price').remove();
		$('.block-filter .type-filter')[0].remove();
	}
}

const filterMobile = () => {
	$('.nav-filter .item').on('click', function() {
		const toggleView = $(this).attr('toggle-view');
		$('.aside-filter .block-filter').each(function() {
			const toggleId = $(this).attr('toggle-id');
			if (toggleView == toggleId) {
				$(this).slideToggle();
				$('.aside-filter .block-filter').not(this).slideUp();
			} else {
				console.log('Không tồn tại toggleView');
			}
		})
	});

	$('#overlay').on('click', function() {
		$(this).removeClass('active');
		$('body').removeClass('disabled');
		$('.aside-filter .block-filter').slideUp();
	});
}

const ajaxFormContact = () => {
	$('.block-form-contact .block-form button').on('click', function(e) {
		e.preventDefault();
		const url = $(this).attr('data-url');
		const Name = $('#name').val();
		const Phone = $('#phone').val();
		const Email = $('#email').val();
		const Content = $('#content').val();
		if ($(".block-send-mail form").valid() == true) {
			$.ajax({
				type: "POST",
				url: url,
				data: {
					Name: Name,
					Phone: Phone,
					Email: Email,
					Content: Content
				},
				success: function(res) {
					if (res.Code === 200) {
						alert(res.Message);
					} else {
						alert(res.Message);
					}
				}
			});
		} else {
			console.log('Không được request lên url vì valid');
		}
	});
}

const getFormData = (obj) => {
	let formData = new FormData();
	for (let field in obj) {
		formData.append(field, obj[field])
	}
	return formData;
}

const ajaxOrderProduct = () => {
	$('.popup-checkout .form-button button').on('click', function(e) {
		e.preventDefault();
		let fields = {
			RecipientName: $('#fullname').val(),
			RecipientPhone: $('#phone').val(),
			ShippingAddress: $('#address').val(),
		};

		const url = $(this).attr('data-url');
		if ($(".popup-checkout form").valid() === true) {
			$.ajax({
				type: "POST",
				url: url,
				data: getFormData(fields),
				processData: false,
				contentType: false,
				success: function(res) {
					if (res.Code === 200) {
						$.fancybox.open({
							src: '#popup-checkout-complete',
							type: 'inline',
							opts: {
								hash: false,
								closeExisting: true,
							}
						});
					} else {
						alert(res.Message)
					}
				}
			});
		} else {
			console.log('Không được request lên url vì valid');
		}
	});
}

// CHECK LAYOUT CÓ BANNER KHÔNG
const checkLayoutBanner = () => {
	const mainSlider = $('.home-banner');
	const normalSLider = $('.main-banner');
	const heightHeader = $('header').outerHeight();
	if ($(window).width() < 1025 && mainSlider.length >= 1 && mainSlider.css('display') == 'block') {
		mainSlider.css('padding-top', heightHeader);
	} else if ($(window).width() < 1025 && normalSLider.length >= 1 && normalSLider.css('display') == 'block') {
		normalSLider.css('padding-top', heightHeader);
	} else {}
}

// SHOW BACK TO TOP
const showBackToTop = () => {
	$(window).scroll(function() {
		if ($(this).scrollTop() > 800) {
			$('#back-to-top').addClass('active');
		} else {
			$('#back-to-top').removeClass('active');
		}
	});

	$("#back-to-top").on("click", function(e) {
		e.preventDefault();
		$("html,body").animate({
			scrollTop: 0
		})
	})
}

const keyupAsideFilter = () => {
	$(".aside-filter .block-filter .brand .search input").on('keyup', function() {
		const valSearch = $(this).val().toLowerCase();
		const Listitem = $(".aside-filter .block-filter .brand .check-box .form-group input");

		Listitem.each(function() {
			const valCheckBox = $(this).val().toLowerCase();
			if (valSearch !== "") {
				if (valCheckBox.search(valSearch) != -1) {
					$(this).parents('.form-group').css('display', "block");
				} else {
					$(this).parents('.form-group').css('display', "none");
				}
			} else {
				$(this).parents('.form-group').css('display', "block");
			}
		});
	});
}

document.addEventListener('DOMContentLoaded', () => {
	// LOADING !!!
	Loading().then(() => {
		new WOW().init();
		// GET HEIGHT SOMWE ELEMENT
		setHeightOverFolowBySomeElement('.about-1,.about-3,.product-detail-1');
		setHeightThumbnailSliderProductDetail();
		activeHeaderWhenScroll();
	});
	checkLayoutBanner();
	toggleMenuMobile();
	toggleCartMenu();
	activeMenuOnSmallDesktop();
	initializationClassSubMenu();
	SubMenuMobile();
	// SLIDER HERE !!!
	mainSlider();
	productDetailSlider();
	productOtherSlider();
	// SLIDER NHÀ PHÂN PHỐI !!!
	distributorSlider();
	// SLIDER KHÁCH HÀNG !!!
	customerSlider();
	// FILTER GIÁ
	rangeSliderPrice();
	filterMobile();
	//AJAX
	ajaxFormContact();
	ajaxOrderProduct();
	// TAB
	const tabProductDetail = new Tab('.product-detail-2');
	CartController();
	CommonController();
	checkPageToAddClassMainSlider();
	showBackToTop();
	keyupAsideFilter();
});

window.addEventListener('scroll', () => {
	activeHeaderWhenScroll();
})

document.addEventListener('resize', () => {
	// TAM GIÁC LOGO HEADER !!!
	activeMenuOnSmallDesktop();
	activeHeaderWhenScroll();
	setHeightOverFolowBySomeElement('.about-1,.about-3,.product-detail-1');
	setHeightThumbnailSliderProductDetail();
})