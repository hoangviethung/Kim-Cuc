using MainProject.SCommerce.LandingPage.Models.Product;
using MainProject.SCommerce.LandingPage.Models.Cart;
using System.Web.Mvc;

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
            return View(new ProductDetailViewModel());
        }
    }
}