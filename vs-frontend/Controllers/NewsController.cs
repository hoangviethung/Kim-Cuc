using MainProject.SBussiness.LandingPage.Models.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MainProject.Controllers
{
    public class NewsController : Controller
    {
        public ActionResult News()
        {
            return View(new NewsViewModel());
        }
    }
}