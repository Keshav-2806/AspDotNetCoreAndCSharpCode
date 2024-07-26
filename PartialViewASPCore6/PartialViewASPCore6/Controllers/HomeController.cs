using Microsoft.AspNetCore.Mvc;
using PartialViewASPCore6.Models;
using System.Diagnostics;

namespace PartialViewASPCore6.Controllers
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
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Products()
        {
            List<Product> products = new List<Product>()
            {
                new Product() {Id=101,Name="PicOne",Description="Description1",Price=10000.00,Image="~/Images/beautifulImage1.jpg"},
                new Product() {Id=102,Name="PicTwo",Description="Description2",Price=8000.00,Image="~/Images/beautifulImage2.jpg"},
                
            };   
            return View(products);
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