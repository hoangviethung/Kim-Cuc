﻿using MainProject.Core;
using MainProject.Core.Commerce;
using MainProject.Framework.Helpers;
using System.Collections.Generic;

namespace MainProject.SBussiness.LandingPage.Models.Home
{
    //MODEL CỦA TRANG CHỦ
    public class HomeViewModel
    {
        public Category Categorys { get; set; }
        //DANH SÁCH ẢNH NHÀ TÀI TRỢ
        public List<Brand> Brands { get; set; } = new List<Brand>
        {
             new Brand
            {
                ImageDefault = "/Content/resources/assets/images/distributor/1.png",
                Name = "NHÀ PHÂN PHỐI KIM CÚC SPORTS",
            },
            new Brand
            {
                ImageDefault = "/Content/resources/assets/images/distributor/2.png",
                Name = "NHÀ PHÂN PHỐI KIM CÚC SPORTS",
            },
            new Brand
            {
                ImageDefault = "/Content/resources/assets/images/distributor/3.png",
                Name = "NHÀ PHÂN PHỐI KIM CÚC SPORTS",
            },
            new Brand
            {
                ImageDefault = "/Content/resources/assets/images/distributor/4.png",
                Name = "NHÀ PHÂN PHỐI KIM CÚC SPORTS",
            },
            new Brand
            {
                ImageDefault = "/Content/resources/assets/images/distributor/5.png",
                Name = "NHÀ PHÂN PHỐI KIM CÚC SPORTS",
            }
        };
        //DANH SÁCH SẢN PHẨM HOT
        public List<Core.Commerce.Product> HotProducts { get; set; } = new List<Core.Commerce.Product>
        {
            new Core.Commerce.Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/hot-sale/1.png",
                ExternalUrl ="Product/Detail",
            },
             new Core.Commerce.Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/hot-sale/2.png",
                ExternalUrl ="Product/Detail",
            },
            new Core.Commerce.Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/hot-sale/3.png",
                ExternalUrl ="Product/Detail",
            },
            new Core.Commerce.Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/hot-sale/4.png",
                ExternalUrl ="Product/Detail",
            },
             new Core.Commerce.Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/hot-sale/5.png",
                ExternalUrl ="Product/Detail",
            },
            new Core.Commerce.Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/hot-sale/6.png",
                ExternalUrl ="Product/Detail",
            },
            new Core.Commerce.Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/hot-sale/7.png",
                ExternalUrl ="Product/Detail",
            },
             new Core.Commerce.Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/hot-sale/8.png",
                ExternalUrl ="Product/Detail",
            },
              new Core.Commerce.Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/hot-sale/9.png",
                ExternalUrl ="Product/Detail",
            },
              new Core.Commerce.Product
             {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/hot-sale/10.png",
                ExternalUrl ="Product/Detail",
                },
        };
        //DANH SÁCH SẢN PHẨM THỂ THAO
        public List<Core.Commerce.Product> SportProducts { get; set; } = new List<Core.Commerce.Product>
        {
             new Core.Commerce.Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/sports/1.png",
                 ExternalUrl ="Product/Detail",
            },
             new Core.Commerce.Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/sports/2.png",
                 ExternalUrl ="Product/Detail",
            },
            new Core.Commerce.Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/sports/3.png",
                 ExternalUrl ="Product/Detail",
            },
            new Core.Commerce.Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/sports/4.png",
                 ExternalUrl ="Product/Detail",
            },
             new Core.Commerce.Product
            {
               //MÃ SẢN PHẨM
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 58600000,
                ImageDefault ="/Content/resources/assets/images/products/sports/5.png",
                 ExternalUrl ="Product/Detail",
            },
        };
        //DANH SÁCH KHÁCH HÀNG
        public Introduction Customer { get; set; } = new Introduction
        {
            Image = JsonHelper.Serialize(new List<Core.Image>
            {
                new Core.Image
                {
                    Name = "Trần Văn A",
                    Path = "/Content/resources/assets/images/customer/1.png",
                    Alt ="KHÁCH HÀNG KIM CÚC SPORTS",
                },
                new Core.Image
                {
                    Name = "Trần Văn B",
                    Path = "/Content/resources/assets/images/customer/2.png",
                    Alt ="KHÁCH HÀNG KIM CÚC SPORTS",
                },
                new Core.Image
                {
                    Name = "Trần Văn C",
                    Path = "/Content/resources/assets/images/customer/3.png",
                    Alt ="KHÁCH HÀNG KIM CÚC SPORTS",
                },
                new Core.Image
                {
                    Name = "Trần Văn D",
                    Path = "/Content/resources/assets/images/customer/4.png",
                    Alt ="KHÁCH HÀNG KIM CÚC SPORTS",
                },
                new Core.Image
                {
                    Name = "Trần Văn E",
                    Path = "/Content/resources/assets/images/customer/5.png",
                    Alt ="KHÁCH HÀNG KIM CÚC SPORTS",
                },
            })
        };
        //DANH SÁCH TIN TỨC TRANG CHỦ
        public List<Article> HotNews { get; set; } = new List<Article>
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
        // List Menu
        public string Menu { get; set; } = ResourceHelper.ReadFile("/App_Data/Read_File/HeaderMenu.txt");
        //DANH SÁCH ẢNH BANNER
        public List<Banner> Banners { get; set; } = new List<Banner>
        {
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/banner/1.png",
                Alt = "BANNER QUẢNG CÁO 1",
            },
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/banner/2.png",
                Alt = "BANNER QUẢNG CÁO 2",
            },
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/banner/3.png",
                Alt = "BANNER QUẢNG CÁO 3",
            },
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/banner/4.png",
                Alt = "BANNER QUẢNG CÁO 4",
            },
            new Banner
            {
                ResourcePath = "/Content/resources/assets/images/banner/5.png",
                Alt = "BANNER QUẢNG CÁO 5",
            }
        };
    }

    //MODEL CỦA FOOTER
    public class FooterViewModel
    {
        //DANH SÁCH MENU CATEGORY
        public string Menu { get; set; } = ResourceHelper.ReadFile("/App_Data/Read_File/FooterMenu.txt");
        //DANH SÁCH MENU COPYRIGHT
        public List<Article> Articles { get; set; } = new List<Article>
        {

        };
        //DANH SÁCH THÔNG TIN CỦA CÔNG TY
        public Branch Branch { get; set; } = new Branch
        {
            Phone = "0906.523.876",
            Email = "kimcucsport@gmail.com",
            Address = "133 - 143 Hùng Vương, t.p Quảng Ngãi",
            Description = "https://www.facebook.com/kimcucsports/",
        };
    }
}