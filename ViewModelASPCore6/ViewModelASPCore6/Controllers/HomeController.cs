using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewModelASPCore6.Models;

namespace ViewModelASPCore6.Controllers
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
            List<Student> students = new List<Student>
            {
                new Student { Id = 1,Name="Keshav",Gender="Male",Standard=12},
                new Student { Id = 2,Name="Madhav",Gender="Male",Standard=13},
                new Student { Id = 1,Name="Mukund",Gender="Male",Standard=10},
            };

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher { Id = 1,Name="Hans",Qualification="BTech",Salary=50000},
                new Teacher { Id = 2,Name="Raj",Qualification="MCA",Salary=30000},
                new Teacher { Id = 3,Name="Aman",Qualification="BA",Salary=10000},
            };

            SchoolViewModel svm = new SchoolViewModel()
            {
                myStudents=students,
                myTeachers=teachers
            };
            return View(svm);
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