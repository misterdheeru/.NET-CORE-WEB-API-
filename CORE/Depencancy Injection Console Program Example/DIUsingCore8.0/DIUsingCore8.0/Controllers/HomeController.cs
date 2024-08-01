using Microsoft.AspNetCore.Mvc;

namespace DIUsingCore8._0.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
