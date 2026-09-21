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

        [HttpGet]
        [Route("SteveComputerTrainingCertification")]
        public IActionResult SteveComputerTrainingCertification()
        {
            return View("SteveComputerTrainingCertification");
        }

        [HttpGet]
        [Route("EmployeeTimesheet")]
        public IActionResult EmployeeTimesheet()
        {
            return View("EmployeeTimesheet");
        }

        [HttpGet]
        [Route("SteveComputerTraining")]
        public IActionResult SteveComputerTraining()
        {
            return View("SteveComputerTraining");
        }

        [HttpGet]
        [Route("SteveComputerTrainingv2")]
        public IActionResult SteveComputerTrainingv2()
        {
            return View("SteveComputerTrainingv2");
        }

        [HttpGet]
        [Route("VideoStore")]
        public IActionResult VideoStore()
        {
            return View("VideoStore");
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
