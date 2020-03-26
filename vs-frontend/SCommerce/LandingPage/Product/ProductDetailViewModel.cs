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
            Brand = new Brand
            {

            }
        };

        public List<Core.Commerce.Product> Products { get; set; } = new List<Core.Commerce.Product>
        {

        };
    }
}