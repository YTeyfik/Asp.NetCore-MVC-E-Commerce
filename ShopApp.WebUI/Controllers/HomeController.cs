using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;
using System;
using System.Collections.Generic;

namespace ShopApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        //localhost:5000/home/index
        public IActionResult Index()
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
        //localhost:5000/home/about
        public IActionResult About()
        {
            return View();
            //return View("MyPage"); Bu yöntemde about olarak çağırmak yerine verdiğimiz string ifade ile bulmaya çalışır
        }
    }
}
