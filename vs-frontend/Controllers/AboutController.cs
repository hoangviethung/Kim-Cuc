using MainProject.SBussiness.LandingPage.Models.About;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MainProject.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult About()
        {
            return View(new AboutViewModel());
        }
    }
}