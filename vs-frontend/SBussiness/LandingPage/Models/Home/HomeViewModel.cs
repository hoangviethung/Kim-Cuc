using MainProject.Core;
using MainProject.Core.Commerce;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MainProject.SBussiness.LandingPage.Models.Home
{
    //MODEL CỦA TRANG CHỦ
    public class HomeViewModel
    {
        //DANH SÁCH TITLE TRANG CHỦ
        public List<Category> TitleHome = new List<Category>
        {
            new Category
            {
                Title = "NHÀ PHÂN PHỐI CHÍNH HÃNG CÁC THƯƠNG HIỆU"
            },
            new Category
            {
                Title = "SẢN PHẨM BÁN CHẠY"
            },
            new Category
            {
                Title = "SẢN PHẨM TẬP THỂ THAO"
            },
            new Category
            {
                Title = "KHÁCH HÀNG CỦA CHÚNG TÔI"
            },
            new Category
            {
                Title = "TIN TIÊU ĐIỂM"
            },
            new Category
            {
                Title = "TIN TỨC - SỰ KIỆN"
            }
        };
        //DANH SÁCH ẢNH NHÀ TÀI TRỢ
        public List<Banner> Distributor { get; set; } = new List<Banner>
        {
             new Banner
            {
                ResourcePath = "/Content/resources/assets/images/distributor/1.png",
                Alt = "NHÀ PHÂN PHỐI KIM CÚC SPORTS",
            },
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/distributor/2.png",
                Alt = "NHÀ PHÂN PHỐI KIM CÚC SPORTS",
            },
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/distributor/3.png",
                Alt = "NHÀ PHÂN PHỐI KIM CÚC SPORTS",
            },
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/distributor/4.png",
                Alt = "NHÀ PHÂN PHỐI KIM CÚC SPORTS",
            },
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/distributor/5.png",
                Alt = "NHÀ PHÂN PHỐI KIM CÚC SPORTS",
            }
        };
        //DANH SÁCH SẢN PHẨM HOT
        public List<Product> HotProduct { get; set; } = new List<Product>
        {
            new Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/hot-sale/1.png",
            },
             new Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/hot-sale/2.png",
            },
            new Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/hot-sale/3.png",
            },
            new Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/hot-sale/4.png",
            },
             new Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/hot-sale/5.png",
            },
            new Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/hot-sale/6.png",
            },
            new Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/hot-sale/7.png",
            },
             new Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/hot-sale/8.png",
            },
              new Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/hot-sale/9.png",
            },
              new Product
             {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/hot-sale/10.png",
                },
        };
        //DANH SÁCH SẢN PHẨM THỂ THAO
        public List<Product> SportsProduct { get; set; } = new List<Product>
        {
             new Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/sports/1.png",
            },
             new Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/sports/2.png",
            },
            new Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/sports/3.png",
            },
            new Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/sports/4.png",
            },
             new Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/sports/5.png",
            },
        };
        //DANH SÁCH KHÁCH HÀNG
        public List<Banner> Customer { get; set; } = new List<Banner>
        {
            new Banner
            {
                Name = "Trần Văn A",
                ResourcePath = "/Content/resources/assets/images/customer/1.png",
                Alt ="KHÁCH HÀNG KIM CÚC SPORTS",
            },
            new Banner
            {
                Name = "Trần Văn B",
                ResourcePath = "/Content/resources/assets/images/customer/2.png",
                Alt ="KHÁCH HÀNG KIM CÚC SPORTS",
            },
            new Banner
            {
                Name = "Trần Văn C",
                ResourcePath = "/Content/resources/assets/images/customer/3.png",
                Alt ="KHÁCH HÀNG KIM CÚC SPORTS",
            },
            new Banner
            {
                Name = "Trần Văn D",
                ResourcePath = "/Content/resources/assets/images/customer/4.png",
                Alt ="KHÁCH HÀNG KIM CÚC SPORTS",
            },
            new Banner
            {
                Name = "Trần Văn E",
                ResourcePath = "/Content/resources/assets/images/customer/5.png",
                Alt ="KHÁCH HÀNG KIM CÚC SPORTS",
            },
        };
        //DANH SÁCH TIN TỨC TRANG CHỦ
        public List<Article> HomeNews { get; set; } = new List<Article>
        {
            new Article {
                    Id = 001,
                    Title = "Tin tức nổi bật của Kim Cúc Sports",
                    ImageDefault = "/Content/resources/assets/images/news/home-news/1.png",
                    CreateDate = System.DateTime.Now,
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, and when an unknown printer took a galley of type and scrambled it to make a type made specimen book. It has survived not only five centuries, but also the leap into and type electronic typesetting, remaining essentially unchanged.",
            },
            new Article {
                    Id = 002,
                    Title = "Tin tức nổi bật của Kim Cúc Sports",
                    ImageDefault = "/Content/resources/assets/images/news/home-news/2.png",
                    CreateDate = System.DateTime.Now,
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, and when an unknown printer took a galley of type and scrambled it to make a type made specimen book. It has survived not only five centuries, but also the leap into and type electronic typesetting, remaining essentially unchanged.",
            },
            new Article {
                    Id = 003,
                    Title = "Tin tức nổi bật của Kim Cúc Sports",
                    ImageDefault = "/Content/resources/assets/images/news/home-news/3.png",
                    CreateDate = System.DateTime.Now,
                    Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, and when an unknown printer took a galley of type and scrambled it to make a type made specimen book. It has survived not only five centuries, but also the leap into and type electronic typesetting, remaining essentially unchanged.",
            },
            new Article {
                Id = 004,
                Title = "Tin tức nổi bật của Kim Cúc Sports",
                ImageDefault = "/Content/resources/assets/images/news/home-news/4.png",
                CreateDate = System.DateTime.Now,
                Description = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, and when an unknown printer took a galley of type and scrambled it to make a type made specimen book. It has survived not only five centuries, but also the leap into and type electronic typesetting, remaining essentially unchanged.",
            },
        };
    }

    //MODEL CỦA HEADER
    public class HeaderViewModel
    {
        //DANH SÁCH ẢNH BANNER
        public List<Banner> Banners { get; set; } = new List<Banner>
        {
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/banner/home-banner.png",
                Alt = "BANNER QUẢNG CÁO 1",
            },
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/banner/normal-banner-1.png",
                Alt = "BANNER QUẢNG CÁO 2",
            },
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/banner/normal-banner-2.png",
                Alt = "BANNER QUẢNG CÁO 3",
            },
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/banner/normal-banner-3.png",
                Alt = "BANNER QUẢNG CÁO 4",
            },
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/banner/normal-banner-4.png",
                Alt = "BANNER QUẢNG CÁO 4",
            }
        };
    }

    //MODEL CỦA FOOTER
    public class FooterViewModel
    {
        //DANH SÁCH THÔNG TIN CỦA CÔNG TY
        public List<Branch> Branch { get; set; } = new List<Branch>
        {
            new Branch
            {
                Phone = "0906.523.876",
                Email = "kimcucsport@gmail.com",
                Address = "133 - 143 Hùng Vương, t.p Quảng Ngãi",
                Description = "https://www.facebook.com/kimcucsports/",
            }
        };
        //DANH SÁCH LINK THEO DANH MỤC CỦA FOOTER
        public List<Category> ListLinkCategoryFooter { get; set; } = new List<Category>
        {
            new Category
            {
                Title = "Phụ kiện thể thao",
            },
             new Category
            {
                Title = "Xe đạp tập",
            },
              new Category
            {
                Title = "Máy chạy bộ điện",
            },
               new Category
            {
                Title = "Ghế massage",
            }
        };
        //DANH SÁCH LINK Ở THANH COPYRIGHT
        public List<Category> ListLinkCopyRight = new List<Category>
        {
            new Category
            {
                Title = "Điều kiện"
            },
              new Category
            {
                Title = "Điều khoản"
            },
                new Category
            {
                Title = "Chính sách bảo mật"
            }
        };
    }
}