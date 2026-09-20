using AzureSteveMiazga.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AzureSteveMiazga.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("CookCountyPortal")]
        public IActionResult CookCountyPortal()
        {
            return View("CookCountyPortal");
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
