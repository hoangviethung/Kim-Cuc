using System.Collections.Generic;
using System.Linq;

namespace MainProject.SCommerce.LandingPage.Models.Cart
{
    public class CartViewModel
    {
        public List<CartItemModel> ShoppingCartItems { get; set; } = new List<CartItemModel>
        {

        };
        public string TotalAmountFormat { get; set; }
        public string DiscountAmountFormat { get; set; }
        public string ShippingFeeFormat { get; set; }
        public string AfterDiscount { get; set; }

        public CartViewModel() { }
    }
}