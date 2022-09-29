using Microsoft.AspNetCore.Mvc;
using OneClickShopping.Managment.Models;
using System.Diagnostics;

namespace OneClickShopping.Managment.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult HomePage() => View();
 

        
    }
}