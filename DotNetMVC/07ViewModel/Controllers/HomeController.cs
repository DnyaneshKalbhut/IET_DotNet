using System.Security.Cryptography.X509Certificates;
using _07ViewModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace _07ViewModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ProductViewModel productViewModel = new ProductViewModel() { 
            
                Product  = new Product() { Id=10 , Name="Laptop" , price=21132},
                CategoryName="Electronics ",
                isAvailable=true,
                Message="Company = Asus Rog , i5 11th Gen"

            };

            return View(productViewModel);
        
        
        }

        public IActionResult Test(Product p) {

            return View(p);
        }

        public IActionResult ProductDetails() { 
        Product product = new Product() { Id = 10, Name = "Laptop", price = 21132 };
            return View(product);
        }
    }
}
