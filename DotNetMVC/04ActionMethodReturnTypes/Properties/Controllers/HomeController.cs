using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace _04ActionMethodReturnTypes.Properties.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        // url -> https://localhost:44394/home/GetSomeName?Name=vikram
        public ActionResult<string> GetSomeName(string Name) 
        {
            string output = $"YOur Entered Name is {Name}";
            
            return output;
        }

        //url -> https://localhost:44394/home/GetJsonData
        public JsonResult GetJsonData()
        {
            var data = new {Name="IET",Address="Pune",Course="DAC" };
            return Json(data);
        }

        // url -> https://localhost:44394/home/GetMeSomething?id=10&Name=Vikram
        public string GetMeSomething(int id, string Name)
        {
            string output = $"ID + {id} AND NAME = {Name}";
            return output;
        }

        // url -> https://localhost:44394/home/About
        public IActionResult About()
        {
            return View();
        }

        public FileResult DownloadFile() 
        {
            var byteArray = System.IO.File.ReadAllBytes(@"C:\240845920024\DotNet\DotNetMVC\04ActionMethodReturnTypes\Data\data.pdf");
            return File(byteArray, "application/pdf", "data.pdf");
        }

        public EmptyResult Empty() { 
            return new EmptyResult();
        }

        // url -> https://localhost:44394/home/GetDataAsyn
        public async Task<IActionResult> GetDataAsyn() 
        {
            await Task.Delay(2000);
            return View("~/Views/Home/GetData.cshtml");
        }

        // url -> https://localhost:44394/home/GetMeSomeString?Id=10&str=%22Maine%20Bola%20Hi%22
        public string GetMeSomeString(int Id, string str)
        {
            string opStr = $"Id = {Id}, str ={str}";
            return opStr;
        }

        public ObjectResult getSomeObject()
        {
            var obj = new { name = "Dnyanesh", Address = "Pulgaon" };
             return new ObjectResult(obj);
        }

    }
}
