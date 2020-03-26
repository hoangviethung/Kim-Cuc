using MainProject.SBussiness.LandingPage.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MainProject.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View(new ProductViewModel());
        }

        public ActionResult ProductDetail()
        {
            return View(new ProductDetailViewModel());
        }

        public ActionResult Cart()
        {
            return View(new CartViewModel());
        }
    }
}