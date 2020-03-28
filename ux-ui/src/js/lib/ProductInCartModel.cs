using MainProject.Core.Commerce;
using MainProject.Core.Enums;
using MainProject.Framework.Helpers;

namespace MainProject.SCommerce.LandingPage.Models.Cart
{
    public class ProductInCartModel
    {
        #region Product Information
        /// <summary>
        /// Product Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Product property Id
        /// </summary>
        public long PropertyId { get; set; }

        /// <summary>
        /// Product name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Product Brand
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Product image
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Url to product detail
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Product unit price
        /// </summary>
        public string Price { get; set; } 
        #endregion

        /// <summary>
        /// Total price of product (Price * Quantity)
        /// </summary>
        public string ItemAmount { get; set; }

        /// <summary>
        /// Quantity of this product in shopping cart
        /// </summary>
        public int ItemCount { get; set; }

        /// <summary>
        /// Total products's quantity in shopping cart
        /// </summary>
        public int TotalQuantity { get; set; }

        /// <summary>
        /// Total price of this product (Quantity * Price) after format currency
        /// </summary>
        public string TotalAmount { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        public string Currency { get; set; }

        public ProductInCartModel() { }

        public ProductInCartModel(ShoppingCartItem entity)
        {
            Id = entity.Product.Id;
            Name = entity.Product.Name;
            Brand = entity.Product.Brand.Name;
            Image = entity.Product.ImageDefault;
            Url = entity.Product.GetUrl();
            ItemCount = entity.Quantity;
            PropertyId = entity.Property != null ? entity.Property.Id : 0;
            Price = MvcHtmlHelper.FormatPrice(entity.Product.GetPrice());
            Currency = ResourceHelper.GetResource(ResourceKeyCollection.Currency);
        }
    }
}
