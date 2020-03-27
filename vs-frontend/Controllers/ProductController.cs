using MainProject.SCommerce.LandingPage.Models.Product;
using MainProject.SCommerce.LandingPage.Models.Cart;
using System.Web.Mvc;
using System.Collections.Generic;

namespace MainProject.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View(new ProductViewModel());
        }

        public ActionResult Detail()
        {
            return View(new ProductDetailViewModel() { 
                Products = new List<ProductDetailViewModel>
            {
                new ProductDetailViewModel
                {
                    Name = "Ghế massage Okasa",
                    Code ="OS-868",
                    Image ="/Content/resources/assets/images/products/list-product/1.png",
                    Price = 999999999,
                    Url = "/product/detail",
                    Products = null
                },
                 new ProductDetailViewModel
                {
                    Name = "Ghế massage Okasa",
                    Code ="OS-868",
                    Image ="/Content/resources/assets/images/products/list-product/2.png",
                    Price = 999999999,
                    Url ="/product/detail",
                    Products = null
                },
                  new ProductDetailViewModel
                {
                    Name = "Ghế massage Okasa",
                    Code ="OS-868",
                    Image ="/Content/resources/assets/images/products/list-product/3.png",
                    Price = 999999999,
                    Url ="/product/detail"
                },
                   new ProductDetailViewModel
                {
                    Name = "Ghế massage Okasa",
                    Code ="OS-868",
                    Image ="/Content/resources/assets/images/products/list-product/4.png",
                    Price = 999999999,
                    Url ="/product/detail"
                },
                    new ProductDetailViewModel
                {
                    Name = "Ghế massage Okasa",
                    Code ="OS-868",
                    Image ="/Content/resources/assets/images/products/list-product/5.png",
                    Price = 999999999,
                    Url ="/product/detail"
                },
            }
            });
        }
    }
}