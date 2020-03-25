using MainProject.SBussiness.LandingPage.Models.ProductSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MainProject.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductSite
        public ActionResult ProductSite()
        {
            return View(new ProductSiteViewModel());
        }
    }
}