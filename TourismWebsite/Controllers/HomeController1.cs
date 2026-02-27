using Microsoft.AspNetCore.Mvc;

namespace TourismWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Packages()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Trips()
        {
            return View();
        }
        public IActionResult Cultural()
        {
            return View();
        }


        public IActionResult Visas()
        {
            return View();
        }

        public IActionResult Destination(string name)
        {
            ViewBag.DestinationName = name;
            return View();
        }
        public IActionResult Package(string name)
        {
            ViewBag.PackageName = name;
            return View();
        }

    }
}
