using MainProject.SBussiness.LandingPage.Models.Policy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MainProject.Controllers
{
    public class PolicyController : Controller
    {
        // GET: Policy
        public ActionResult Policy()
        {
            return View(new PolicyViewModel());
        }
    }
}