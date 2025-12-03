using System.Diagnostics;
using A3._5EjerciciosdeASPTagHelpers.Models;
using Microsoft.AspNetCore.Mvc;

namespace A3._5EjerciciosdeASPTagHelpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
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
