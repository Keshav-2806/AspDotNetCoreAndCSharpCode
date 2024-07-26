using Microsoft.AspNetCore.Mvc;
using ReposatoryPatternASPCore.Models;
using RepositoryPatternASPCore.Models;
using RepositoryPatternASPCore.Repository;
using System.Diagnostics;

namespace ReposatoryPatternASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository = null;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }
        public List<StudentModel> GetAllStudents()
        {
            return _studentRepository.getAllStudents();
        }
        public StudentModel getById(int id)
        {
            return _studentRepository.getStudentById(id);
        }
        public IActionResult Index()
        {
            //var students = new List<StudentModel>
            //{
            //    new StudentModel { StdId = 1,StdName="Keshav",StdGender="Male",StdStandard=12},
            //    new StudentModel { StdId = 2,StdName="Madhav",StdGender="Male",StdStandard=12}

            //};
            //ViewData["myStudent"]=students;
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