using MainProject.Core;
using MainProject.Core.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainProject.SCommerce.LandingPage.Models.Product
{
    public class ProductDetailViewModel
    {
        public Core.Commerce.Product Product { get; set; } = new Core.Commerce.Product
        {
            ProductCode = "001",
            Brand = new Brand
            {
                Name = "Adidas",
            },
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
            Body = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.</p><p> Lorem ipsum dolor sit amet,consectetur adipiscing elit,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam,quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.</p><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.</p><p> Lorem ipsum dolor sit amet,consectetur adipiscing elit,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam,quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.</p>"
        };

        public List<Core.Commerce.Product> Products { get; set; } = new List<Core.Commerce.Product>
        {
            new Core.Commerce.Product
            {
                Name = "Ghế massage Okasa",
                ProductCode ="OS-868",
                ImageDefault ="/Content/resources/assets/images/products/list-product/1.png",
                Price = 999999999,
                ExternalUrl ="/product/detail"
            },
             new Core.Commerce.Product
            {
                Name = "Ghế massage Okasa",
                ProductCode ="OS-868",
                ImageDefault ="/Content/resources/assets/images/products/list-product/2.png",
                Price = 999999999,
                ExternalUrl ="/product/detail"
            },
              new Core.Commerce.Product
            {
                Name = "Ghế massage Okasa",
                ProductCode ="OS-868",
                ImageDefault ="/Content/resources/assets/images/products/list-product/3.png",
                Price = 999999999,
                ExternalUrl ="/product/detail"
            },
               new Core.Commerce.Product
            {
                Name = "Ghế massage Okasa",
                ProductCode ="OS-868",
                ImageDefault ="/Content/resources/assets/images/products/list-product/4.png",
                Price = 999999999,
                ExternalUrl ="/product/detail"
            },
                new Core.Commerce.Product
            {
                Name = "Ghế massage Okasa",
                ProductCode ="OS-868",
                ImageDefault ="/Content/resources/assets/images/products/list-product/5.png",
                Price = 999999999,
                ExternalUrl ="/product/detail"
            },
        };
    }
}