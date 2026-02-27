using Microsoft.AspNetCore.Mvc;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Configuration;
namespace TourismWebsite.Controllers
{
    public class HomeController : Controller

    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
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

        public IActionResult Gallery()
        {
            var cloudName = _configuration["CloudinarySettings:CloudName"];
            var apiKey = _configuration["CloudinarySettings:ApiKey"];
            var apiSecret = _configuration["CloudinarySettings:ApiSecret"];

            Account account = new Account(cloudName, apiKey, apiSecret);
            Cloudinary cloudinary = new Cloudinary(account);

            var listParams = new ListResourcesParams()
            {
                Type = "upload",
                MaxResults = 50
            };

            var result = cloudinary.ListResources(listParams);

            return View(result.Resources);
        }
    }
}
