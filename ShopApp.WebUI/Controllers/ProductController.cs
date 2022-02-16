using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopApp.Entity;
using ShopApp.WebUI.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        //Default httpget methodu gelir
        public IActionResult Index()
        {
            return View();
        }
        //localhost/product/list
        [HttpGet]
        public IActionResult List(int? id,string q)
        {
            // {controller}/{action}/{id?}
            //product/list/1
            //RouteData.Values["controller"]=>product
            //RouteData.Values["action"]=>list
            //RouteData.Values["id"]=>id

            //var products = ProductRepository.GetAllProducts;

            //if (id != null)
            //{
            //    products=products.Where(p=> p.CategoryId == id).ToList();
            //}

            //if (!string.IsNullOrEmpty(q))
            //{
            //    products=products.Where(index=>index.Name.ToLower().Contains(q.ToLower())|| index.Description.Contains(q.ToLower())).ToList();
            //}

            //var productViewModel = new ProductViewModel()
            //{
            //    Products = products
            //};
            //return View(productViewModel);
            return View();
        }
        //localhost/product/details
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View();
            //return View(ProductRepository.GetProductById(id));
        }
        [HttpGet]
        public IActionResult Create()
        {
            //ViewBag.Categories = new SelectList(CategoryRepository.GetAllCategories,"CategoryId","Name") ;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            //ProductRepository.AddProduct(product);
            //return RedirectToAction("List");
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //ViewBag.Categories = new SelectList(CategoryRepository.GetAllCategories, "CategoryId", "Name");
            //return View(ProductRepository.GetProductById(id));
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            //ProductRepository.EditProduct(product);
            //return RedirectToAction("List");
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int ProductId)
        {
            //ProductRepository.DeleteProduct(ProductId);
            //return RedirectToAction("list");
            return View();
        }
    }
}
