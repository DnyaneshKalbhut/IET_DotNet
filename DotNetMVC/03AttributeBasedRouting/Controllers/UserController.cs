using Microsoft.AspNetCore.Mvc;

namespace _03AttributeBasedRouting.Controllers
{

    [Route("[controller]")]
    public class UserController : Controller
    {
        [Route("[action]")]
         public IActionResult Index()
        {
            return View();
        }

        [Route("[action]/{id?}")]
        public int getID(int? id)
        {
            return id ??= 555;   //Null- coleacing operator
                                 // ?? - instead of null some default set value - return 
        }
    }
}
