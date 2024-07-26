using Microsoft.AspNetCore.Mvc;

namespace ControllerAndActions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["data1"] = "View Data";
            ViewBag.data2 = "View Bag";
            TempData["data3"] = "Temp Data";
            TempData.Keep();
            TempData["data4"] = new List<string>()
            {
                "Cricket","Football","Hockey"
            };
            //  TempData["data4"] = null;
            return View();
        }
        public IActionResult About()
        {
            TempData.Keep();
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public string Display()
        {
            return "Welcome to CTS";
        }
        public int DisplayId(int id)
        {
            return id;
        }
    }
}


//ViewBag.data1 = "CTS";
//ViewBag.data2 = 26;
//ViewBag.data3 = DateTime.Now.ToShortDateString();
//string[] arr = { "Keshav", "Kumar", "Chy" };
//ViewBag.data4 = arr;
//ViewBag.data5 = new List<string>()
//{
//    "Cricket","Football","Hockey"
//};

//ViewData["myName"] = "Keshav Kumar";

//ViewBag.data6 = "Welcome to my cts account.";


//View Data
//ViewData["data1"] = "CTS";
//ViewData["data2"] = 26;
//ViewData["data3"] = DateTime.Now.ToLongDateString();
//string[] arr = { "Keshav", "Kumar", "Choudhary" };
//ViewData["data4"] = arr;

//ViewData["data5"] = new List<string>()
//{
//    "Cricket","Football","Hockey"
//};
