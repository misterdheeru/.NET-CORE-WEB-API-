using Exmp1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exmp1.Controllers
{
    public class AddAccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginMode DATA)
        {
            return View();
        }
        public IActionResult Password(LoginMode DATA)
        {
            return View();
        }

        public IActionResult Show(LoginMode DATA)
        {
            return View();
        }
    }
}
