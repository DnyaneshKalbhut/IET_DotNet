using System.Diagnostics;
using _14CodeFirstEF.Models;
using Microsoft.AspNetCore.Mvc;

namespace _14CodeFirstEF.Controllers
{
    public class HomeController : Controller
    {
        private readonly DACDbContext _dbContext;

        public HomeController(DACDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var lst = _dbContext.emp.ToList();
            return View(lst);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Emp emp)
        {
            if (ModelState.IsValid)
            {
                _dbContext.emp.Add(emp);
                _dbContext.SaveChanges();
            }

            return RedirectToAction("Index");
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

        [HttpGet]
        public IActionResult Edit(int id) { 
            Emp e = _dbContext.emp.Find(id);
            return View(e);
        }

        [HttpPost]
        public IActionResult Edit(Emp emp)
        {
            _dbContext.emp.Update(emp);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Emp e = _dbContext.emp.Find(id);
            _dbContext.emp.Remove(e);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            Emp emp = _dbContext.emp.Find(id);
            return View(emp);
        }

    }
}
