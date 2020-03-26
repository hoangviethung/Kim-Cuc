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
        public ActionResult Index()
        {
            return View(new NewsViewModel());
        }

        public ActionResult Detail()
        {
            return View(new NewsDetailViewModel());
        }

        public ActionResult About()
        {
            return View(new AboutViewModel());
        }

        public ActionResult Policy()
        {
            return View(new PolicyViewModel());
        }
    }
}