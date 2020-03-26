using MainProject.Core.Commerce;
using System;

namespace MainProject.SCommerce.LandingPage.Models.Cart
{
    public class CartItemModel
    {
        public DateTime LastUpdateTime { get; set; }

        public ShoppingCart ShoppingCart { get; set; }

        public Core.Commerce.Product Product { get; set; }

        public ProductPropertyRef Property { get; set; }

        public string ProductPrice { get; set; }

        public string ProductDefaultPrice { get; set; }

        public int Quantity { get; set; }

        public string Notes { get; set; }

        public decimal ItemAmount { get; set; }

        public string ItemAmountFormat { get; set; }

        public string TotalAmountFormat { get; set; }

        public string AmountItemFormat { get; set; }
    }
}