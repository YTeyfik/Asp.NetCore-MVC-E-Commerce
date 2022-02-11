using Microsoft.AspNetCore.Mvc;
using System;

namespace ShopApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        //localhost:5000/home/index
        public IActionResult Index()
        {
            //int hour = DateTime.Now.Hour;
            //string message = hour > 12 ? "İyi Günler" : "Günaydın";
            //ViewBag.Message = message;
            //ViewBag.Name = "Ali";

            return View();
        }
        //localhost:5000/home/about
        public IActionResult About()
        {
            return View();
            //return View("MyPage"); Bu yöntemde about olarak çağırmak yerine verdiğimiz string ifade ile bulmaya çalışır
        }
    }
}
