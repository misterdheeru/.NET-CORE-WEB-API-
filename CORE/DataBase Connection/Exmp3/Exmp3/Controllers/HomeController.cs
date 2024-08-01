using Exmp3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Exmp3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICostomerDAL _customerDAL;

        public HomeController(ICostomerDAL customerDAL)
        {
            _customerDAL = customerDAL;
        }

        public IActionResult Index()
        {
            var data = _customerDAL.DisplayListEmp();
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
