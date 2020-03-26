using MainProject.SCommerce.LandingPage.Models.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MainProject.Controllers
{
    public class CartController : Controller
    {
        public ActionResult Index()
        {
            return View(new CartViewModel());

        }

        public ActionResult ShowCart()
        {
            return PartialView("_Cart", new CartViewModel());
        }
    }
}