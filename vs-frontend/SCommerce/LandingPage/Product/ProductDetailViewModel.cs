using MainProject.Core.Commerce;
using System;
using System.Collections.Generic;

namespace MainProject.SCommerce.LandingPage.Models.Product
{
    public class ProductDetailViewModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public Brand Brand { get; set; } = new Brand
        {
            Id = 1,
            Name = "Nike",
        };

        public string Image { get; set; }

        public string Images { get; set; }

        public string Code { get; set; }

        public string ImageFolder { get; set; }

        public string Url { get; set; }

        public decimal Price { get; set; }

        public bool IsPromotion { get; set; }

        public decimal PromotionPrice { get; set; }

        public string Description { get; set; }

        public string Specification { get; set; }

        public string Content { get; set; }

        public DateTime Order { get; set; }

        public List<ProductDetailViewModel> Products { get; set; }


        #region SEO
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaImage { get; set; }
        #endregion
    }
}