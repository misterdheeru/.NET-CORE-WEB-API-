using Microsoft.AspNetCore.Mvc;

namespace Project8._0.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About(int id)
        {
            return View();
        }
    }
}
