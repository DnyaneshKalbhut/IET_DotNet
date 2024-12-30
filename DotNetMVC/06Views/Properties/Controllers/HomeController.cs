using System.Collections;
using _06Views.Properties.Models;
using Microsoft.AspNetCore.Mvc;

namespace _06Views.Properties.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Emp emp = new Emp() {Id=10,Name= "Vikram" , Address="Pune"};
            Cust cust = new Cust() { Id=11,Name="Dnyanesh",Address="PUlgaon"};
            ArrayList arr = new ArrayList() { emp , cust};
            return View(arr);
        }
    }
}
