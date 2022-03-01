using Microsoft.AspNetCore.Mvc;
using ShopApp.Bll.Abstract;
using ShopApp.Dal.Abstract;
using ShopApp.WebUI.Models;
using System;
using System.Collections.Generic;

namespace ShopApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        //Injection işlemi--------------------
        private IProductService _productService;

        public HomeController(IProductService productService)
        {
            this._productService = productService;
        }

        //Injection işlemi--------------------


        //localhost:5000/home/index
        public IActionResult Index()
        {

            var productViewModel = new ProductListViewModel()
            {
                Products = _productService.GetHomePageProducts()
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
