using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("~/")]//it call route url when application run
        [Route("Home")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Home/Index")]
        public IActionResult About() 
        {
            return View();
        }
        [Route("{id?}")]
        public int Details(int? id )
        {
            return id ?? 1; 
        }
    }
}
