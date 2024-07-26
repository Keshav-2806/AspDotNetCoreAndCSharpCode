using Microsoft.AspNetCore.Mvc;
using ModelDataUsingViewData.Models;
using System.Diagnostics;

namespace ModelDataUsingViewData.Controllers
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
            //Employee emp = new Employee()
            //{
            //    EmpId = 101,
            //    EmpName = "Keshav",
            //    Designation = "PA",
            //    Salary = 32978
            //};

            var myEmployee = new List<Employee>()
            {
                new Employee {EmpId = 101,EmpName="Keshav",Designation="PA",Salary=32978},
                new Employee {EmpId = 102,EmpName="Madhav",Designation="PAT",Salary=31978},
                new Employee {EmpId = 103,EmpName="Pranav",Designation="PAA",Salary=30978},
                new Employee {EmpId = 104,EmpName="Suraj",Designation="u",Salary=12978},
            };
            // ViewData["myEmployee"] = myEmployee;
            // ViewBag.myEmployee = myEmployee;
            TempData["myEmployee"] = myEmployee;


            //     ViewData["myEmployee"] = emp;//this is for viewData
            //ViewBag.myEmployee = emp;//This is for ViewBag
           // TempData["myEmployee"] = emp;// This is for TempData
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