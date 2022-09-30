using Microsoft.AspNetCore.Mvc;

namespace OneClickShopping.Managment.Controllers
{
    public class ProductController : Controller
    {

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adds()
        {
            return View();
        }
    }
}
