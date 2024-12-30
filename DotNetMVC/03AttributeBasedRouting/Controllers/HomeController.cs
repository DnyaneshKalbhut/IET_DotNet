using Microsoft.AspNetCore.Mvc;

namespace _03AttributeBasedRouting.Controllers
{

    [Route("Home")]
    public class HomeController : Controller
    {

        [Route("")]
        [Route("Index")]
        [Route("~/")]

        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
         public IActionResult About()
        {
            return View();
        }

    }
}
