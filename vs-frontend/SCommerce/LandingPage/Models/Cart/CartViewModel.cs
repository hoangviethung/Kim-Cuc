using MainProject.Framework.Models;
using System.Collections.Generic;
using System.Linq;

namespace MainProject.SCommerce.LandingPage.Models.Cart
{
    public class CartViewModel
    {
        public List<CartItemModel> ShoppingCartItems { get; set; } = new List<CartItemModel> { };
        public decimal TotalAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal ShippingFee { get; set; }
        public decimal AfterDiscount { get; set; }

        public CartViewModel() { }
    }
}