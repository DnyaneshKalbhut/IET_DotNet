using Microsoft.AspNetCore.Mvc;

using _05ViewBagViewData.Model;

namespace _05ViewBagViewData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            string[] Days = new string[] {
                "Saturday","Funday","Sunday"
            };

            //belongs to same action method and can not be accessed
            //in another or diff action methods 
            ViewData["WeekDays"] = Days;

            //ViewBag.key = val;
            Emp emp = new Emp() { Id = 12, Name = "Dk", Address = "Pulgaon" };
            ViewBag.EmpData = emp;

            //one Time data Transfer
            TempData["Message"] = "Hello";

            return View();



        }
 
        public IActionResult About()
        {
            /// ViewBag used ViewData internally.
            //Hence can not keep keys same for both the types

            ViewData["Msg"] = "Hi";
            ViewBag.Msg = "Hello";
            return View();
        }
    }
}
