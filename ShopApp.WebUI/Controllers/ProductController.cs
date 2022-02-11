using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;

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
            return View();
        }
        //localhost/product/details
        public IActionResult Details(int id)
        {
            var p = new Product();
            p.Name = "Iphone X";
            p.Description = "Güzel telefon";
            p.Price = 3000;
            return View(p);
        }
    }
}
