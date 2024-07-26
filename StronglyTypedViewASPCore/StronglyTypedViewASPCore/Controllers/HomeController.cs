using Microsoft.AspNetCore.Mvc;
using StronglyTypedViewASPCore.Models;
using System.Diagnostics;

namespace StronglyTypedViewASPCore.Controllers
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
            //Employee obj = new Employee()
            //{
            //    EmpId = 101,
            //    EmpName="Keshav",
            //    Designation="PA",
            //    Salary=33000
            //};
            var myEmployee = new List<Employee>
            {
                new Employee { EmpId=1,EmpName="Keshav",Designation="PA",Salary=33000},
                new Employee { EmpId=2,EmpName="Madhav",Designation="SM",Salary=450000}
            };
            return View(myEmployee);
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