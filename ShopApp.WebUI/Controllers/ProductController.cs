using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;
using System.Collections.Generic;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //localhost/product/list
        public IActionResult List()
        {
            var products = new List<Product>()
            {
                new Product {Name = "Iphone 7",Price=4000,Description="eh işte"},
                new Product {Name = "Iphone 8",Price=5000,Description="idare eder"},
                new Product {Name = "Iphone 9",Price=6000,Description="orta"},
                new Product {Name = "Iphone X",Price=7000,Description="Güzel"}
            };

            var productViewModel = new ProductViewModel()
            {
                Products = products
            };
            return View(productViewModel);
        }
        //localhost/product/details
        public IActionResult Details(int id)
        {
            //ViewBag
            //Model
            //ViewData
            

            var p = new Product();
            p.Name = "Iphone X";
            p.Description = "Güzel telefon";
            p.Price = 3000;
            //  ViewData["Product"] = p;
            //  ViewBag.product
            return View(p);
        }
    }
}
