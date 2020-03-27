using MainProject.Core;
using MainProject.Core.Commerce;
using MainProject.Framework.Helpers;
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
        public List<ProductDetailViewModel> Products = new List<ProductDetailViewModel>()
        {
            new ProductDetailViewModel()
            {
                Code = "OS-868",
                Brand = null,
                Name = "Ghế massage Okasa",
                Price = 999999,
                Image = "/Content/resources/assets/images/products/list-product/1.png",
                Url = "/Product/Detail"
            },
             new ProductDetailViewModel()
            {
                Code = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                Image = "/Content/resources/assets/images/products/list-product/2.png",
                Url = "/Product/Detail"
            },
              new ProductDetailViewModel()
            {
                Code = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                Image = "/Content/resources/assets/images/products/list-product/3.png",
                Url = "/Product/Detail"
            },
               new ProductDetailViewModel()
            {
                Code = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                Image = "/Content/resources/assets/images/products/list-product/1.png",
                Url = "/Product/Detail"
            },
                new ProductDetailViewModel()
            {
                Code = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                Image = "/Content/resources/assets/images/products/list-product/4.png",
                Url = "/Product/Detail"
            },
                 new ProductDetailViewModel()
            {
                Code = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                Image = "/Content/resources/assets/images/products/list-product/1.png",
                Url = "/Product/Detail"
            },
                  new ProductDetailViewModel()
            {
                Code = "OS-868",
                Brand = null,
                Name = "Ghế massage Okasa",
                Price = 999999,
                Image = "/Content/resources/assets/images/products/list-product/5.png",
                Url = "/Product/Detail"
            },
                   new ProductDetailViewModel()
            {
                Code = "OS-868",
                Brand = null,
                Name = "Ghế massage Okasa",
                Price = 999999,
                Image = "/Content/resources/assets/images/products/list-product/6.png",
                Url = "/Product/Detail"
            },
                    new ProductDetailViewModel()
            {
                Code = "OS-868",
                Brand = null,
                Name = "Ghế massage Okasa",
                Price = 999999,
                Image = "/Content/resources/assets/images/products/list-product/7.png",
                Url = "/Product/Detail"
            },
                new ProductDetailViewModel()
            {
                Code = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                Image = "/Content/resources/assets/images/products/list-product/8.png",
                Url = "/Product/Detail"
            },
                    new ProductDetailViewModel()
            {
                Code = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                Image = "/Content/resources/assets/images/products/list-product/9.png",
                Url = "/Product/Detail"
            },
                new ProductDetailViewModel()
            {
                Code = "OS-868",
                Name = "Ghế massage Okasa",
                Price = 999999,
                Image = "/Content/resources/assets/images/products/list-product/10.png",
                Url = "/Product/Detail"
            },
        };
        public PagingModel PagingModel { get; set; } = new PagingModel(200, 16, 1, "href=''");
        public string CommerceMenu { get; set; } = ResourceHelper.ReadFile("/App_Data/Read_File/Category_Product.txt");

        #region Filtering
        public decimal DefaultFromPrice { get; set; } = new decimal(10000000);

        public decimal DefaultToPrice { get; set; } = new decimal(120000000);

        public decimal FromPrice { get; set; } = new decimal(10000000);

        public decimal ToPrice { get; set; } = new decimal(120000000);

        public List<string> BrandSelectedValues { get; set; } = new List<string>
        {

        };

        public string Type { get; set; }
        #endregion
    }
}