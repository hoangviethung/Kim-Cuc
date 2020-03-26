using MainProject.Core;
using MainProject.Core.Commerce;
using MainProject.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainProject.SCommerce.LandingPage.Models.Product
{
    public class ProductViewModel
    {
        //DANH SÁCH THƯƠNG HIỆU
        public List<Brand> Brands = new List<Brand>
       {
           new Brand
           {
               Name = "Addidas",

           },
           new Brand
           {
               Name = "Wilson&W"
           },
           new Brand
           {
               Name = "Nike"
           },
           new Brand
           {
               Name = "Cyber"
           },
           new Brand
           {
               Name = "Yonex"
           },
       };
        //DANH SÁCH DANH MỤC SẢN PHẨM
        public List<Category> Categories = new List<Category>
        {
            new Category
            {
                Title = "Phụ kiện thể thao",
            },
            new Category
            {
                Title = "máy chạy bộ"
            },
            new Category
            {
                Title = "xe đạp tập thể dục"
            },
            new Category
            {
                Title = "GHẾ MASSAGE"
            }
        };
        //DANH SÁCH SẢN PHẨM TRANG SẢN PHẨM
        public List<Core.Commerce.Product> Products = new List<Core.Commerce.Product>
        {
            new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/1.png",
                ExternalUrl = "/Product/Detail"
            },
             new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/2.png",
                ExternalUrl = "/Product/Detail"
            },
              new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/3.png",
                ExternalUrl = "/Product/Detail"
            },
               new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/1.png",
                ExternalUrl = "/Product/Detail"
            },
                new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/4.png",
                ExternalUrl = "/Product/Detail"
            },
                 new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/1.png",
                ExternalUrl = "/Product/Detail"
            },
                  new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/5.png",
                ExternalUrl = "/Product/Detail"
            },
                   new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/6.png",
                ExternalUrl = "/Product/Detail"
            },
                    new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/7.png",
                ExternalUrl = "/Product/Detail"
            },
                     new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/8.png",
                ExternalUrl = "/Product/Detail"
            },
                      new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/9.png",
                ExternalUrl = "/Product/Detail"
            },
                new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/10.png",
                ExternalUrl = "/Product/Detail"
            },
        };
        public PagingModel PagingModel { get; set; } = new PagingModel(200, 16, 1, "href=''");
    }
}