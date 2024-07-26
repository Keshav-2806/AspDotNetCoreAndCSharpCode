using CodeFirstASPCore6Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CodeFirstASPCore6Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDBContext studentDB;


        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(StudentDBContext studentDB)
        {
            this.studentDB = studentDB;
        }
        public IActionResult Index()
        {
            var stdData= studentDB.Students.ToList();
            return View(stdData);
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