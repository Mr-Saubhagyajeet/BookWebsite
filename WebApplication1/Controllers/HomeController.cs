using Microsoft.AspNetCore.Mvc;

namespace BookStoreApplicationOriginal.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs() 
        {
            return View();
        }
        public IActionResult Login() 
        {
            return View();
        }
        public IActionResult Signup() 
        {
            return View();
        }
    }
}
