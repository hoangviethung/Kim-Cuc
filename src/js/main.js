import Cookie from "./lib/Cookie";
import Loading from "./lib/Loading";
import Mapping from "./lib/MoveElement";

// HEADER HERE !!!
const activeHeaderWhenScroll = () => {
	const header = document.querySelector('header');
	const heightHeader = header.offsetHeight;
	const transitionTime = 300;
	const widthBlockCart = $('.block-cart').outerWidth();
	const navList = $('header .bottom-header .nav-list');
	const transitionEffect = `${transitionTime/1000}s all ease-in-out`;
	header.style.transition = transitionEffect;
	$('.block-logo .triangle').css('transition', transitionEffect);

	// HÀM SET CHIỀU CAO CỦA BORDER !!!
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
	setBorder();

	// HÀM SET PADDING CHO NAV LIST ĐỂ BLOCK CART RỚT XUỐNG !!!
	const paddingRightNavList = () => {
		if ($('header').hasClass('scrolled')) {
			navList.css('padding-right', widthBlockCart)
		} else {
			navList.css('padding-right', 'unset')
		}
	}

	// HÀM ADD CLASS
	const addClassScroll = () => {
		if (window.pageYOffset >= heightHeader) {
			document.querySelector('header').classList.add('scrolled');
		} else {
			document.querySelector('header').classList.remove('scrolled');
		}
	}

	window.addEventListener('scroll', function() {
		setBorder();
		addClassScroll();
		paddingRightNavList();
	})
}

// SLIDER HERE !!!
const homeSlider = () => {
	var swiper = new Swiper('.slider-home-banner .swiper-container', {
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
			el: '.slider-home-banner .swiper-pagination',
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

// SLIDER NHÀ PHÂN PHỐI !!!
const distributorSlider = () => {
	var swiper = new Swiper('.slider-distributor .swiper-container', {
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
			nextEl: '.slider-distributor .swiper-button-next',
			prevEl: '.slider-distributor .swiper-button-prev',
		},
		breakpoints: {
			768: {
				slidesPerView: 2,
				spaceBetween: 10,
			},
			1440: {
				slidesPerView: 6,
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
			768: {
				slidesPerView: 2,
				spaceBetween: 10,
			},
			1440: {
				slidesPerView: 5,
				spaceBetween: 16,
			}
		},
	})
}


document.addEventListener('DOMContentLoaded', () => {
	// LOADING !!!
	Loading();
	// HEADER !!!
	activeHeaderWhenScroll();
	// SLIDER HOME !!!
	homeSlider();
	// SLIDER NHÀ PHÂN PHỐI !!!
	distributorSlider();
	// SLIDER KHÁCH HÀNG !!!
	customerSlider();
});


document.addEventListener('resize', () => {
	// TAM GIÁC LOGO HEADER !!!
	activeHeaderWhenScroll()
})