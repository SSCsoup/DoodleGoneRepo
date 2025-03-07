using System.Diagnostics;
using DoodleGoneWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoodleGoneWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ActionResult Admin()
        {
            
            string apiUri = Url.RouteUrl("DefaultApi", new { controller = "admin" });

            
            Uri apiUrl = new Uri($"{Request.Scheme}://{Request.Host}{Request.PathBase}{apiUri}");

           
            ViewBag.ApiUrl = apiUrl.AbsoluteUri;

            return View();
        }
    }
}
