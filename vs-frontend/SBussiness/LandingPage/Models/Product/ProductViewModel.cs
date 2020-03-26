using MainProject.Core;
using MainProject.Core.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainProject.SBussiness.LandingPage.Models.Product
{
    public class ProductViewModel
    {
        //DANH SÁCH THƯƠNG HIỆU
        public List<Core.Commerce.Product> ListBrand = new List<Core.Commerce.Product>
       {
           new Core.Commerce.Product
           {
               Name = "Addidas",

           },
           new Core.Commerce.Product
           {
               Name = "Wilson&W"
           },
           new Core.Commerce.Product
           {
               Name = "Nike"
           },
           new Core.Commerce.Product
           {
               Name = "Cyber"
           },
           new Core.Commerce.Product
           {
               Name = "Yonex"
           },
       };
        //DANH SÁCH DANH MỤC SẢN PHẨM
        public List<Category> ListCategory = new List<Category>
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
        public List<Core.Commerce.Product> Product = new List<Core.Commerce.Product>
        {
            new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/1.png",
            },
             new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/2.png",
            },
              new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/3.png",
            },
               new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/1.png",
            },
                new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/4.png",
            },
                 new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/1.png",
            },
                  new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/5.png",
            },
                   new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/6.png",
            },
                    new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/7.png",
            },
                     new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/8.png",
            },
                      new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/9.png",
            },
                new Core.Commerce.Product
            {
                ProductCode = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                ImageDefault = "/Content/resources/assets/images/products/list-product/10.png",
            },
        };
    }
}