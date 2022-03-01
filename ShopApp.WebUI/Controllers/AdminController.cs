using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopApp.Bll.Abstract;
using ShopApp.Entity;
using ShopApp.WebUI.Models;
using System.Linq;

namespace ShopApp.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        public AdminController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IActionResult ProductList()
        {
            return View(new ProductListViewModel()
            {
                Products=_productService.GetAll()
            });
        }

        public IActionResult CategoryList()
        {
            return View(new CategoryListViewModel()
            {
                Categories = _categoryService.GetAll()
            });
        }


        [HttpGet]//burası default yazmasanda httpget alıyor 
        public IActionResult ProductCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProductCreate(Product model)
        {
            var entity = new Product()
            {
                Name = model.Name,
                Url = model.Url,
                Price = model.Price,
                Description = model.Description,
                ImageUrl = model.ImageUrl
            };
            _productService.Create(entity);

            var message = new AlertMessage()
            {
                Message = $"{entity.Name} eklendi.",
                AlertType = "success"
            };
            TempData["Message"] = JsonConvert.SerializeObject(message);

            return RedirectToAction("ProductList");
        }

        [HttpGet]//burası default yazmasanda httpget alıyor 
        public IActionResult CategoryCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryCreate(Category model)
        {
            var entity = new Category()
            {
                Name = model.Name,
                Url = model.Url
               
            };
            _categoryService.Create(entity);

            var message = new AlertMessage()
            {
                Message = $"{entity.Name} eklendi.",
                AlertType = "success"
            };
            TempData["Message"] = JsonConvert.SerializeObject(message);

            return RedirectToAction("CategoryList");
        }

        [HttpGet]
        public IActionResult ProductEdit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            //nullable olduğu için int cat ediyoruz
            var entity=_productService.GetByIdWithCategories((int)id); 
            if(entity == null)
            {
                return NotFound();
            }
            var model = new ProductModel()
            {
                ProductId = entity.ProductId,
                Name = entity.Name,
                Url = entity.Url,
                Price = entity.Price,
                Description = entity.Description,
                ImageUrl = entity.ImageUrl,
                IsApproved = entity.IsApproved,
                IsHome = entity.IsHome,
                SelectedCategories = entity.ProductCategories.Select(i => i.Category).ToList()
            };

            ViewBag.Categories = _categoryService.GetAll();
            return View(model);
        }

        [HttpPost]
        public IActionResult ProductEdit(ProductModel model,int[] categoryId)
        {
            var entity=_productService.GetById(model.ProductId);
            if (entity == null)
            {
                return NotFound();
            }
            entity.Name = model.Name;
            entity.Url = model.Url;
            entity.Price = model.Price;
            entity.Description = model.Description;
            entity.ImageUrl = model.ImageUrl;
            entity.IsHome = model.IsHome;
            entity.IsApproved = model.IsApproved;

            _productService.Update(entity,categoryId);

            var message = new AlertMessage()
            {
                Message = $"{entity.Name} güncellendi.",
                AlertType = "success"
            };
            TempData["Message"] = JsonConvert.SerializeObject(message);
           
            ViewBag.Categories = _categoryService.GetAll();
            return RedirectToAction("ProductList");
        }

        [HttpGet]
        public IActionResult CategoryEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //nullable olduğu için int cat ediyoruz
            var entity = _categoryService.GetByIdWithProducts((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new CategoryModel()
            {
                CategoryId = entity.CategoryId,
                Name = entity.Name,
                Url = entity.Url,
                Products = entity.ProductCategories.Select(p => p.Product).ToList()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult CategoryEdit(Category model)
        {
            var entity = _categoryService.GetById(model.CategoryId);
            if (entity == null)
            {
                return NotFound();
            }
            entity.Name = model.Name;
            entity.Url = model.Url;
            _categoryService.Update(entity);

            var message = new AlertMessage()
            {
                Message = $"{entity.Name} güncellendi.",
                AlertType = "success"
            };
            TempData["Message"] = JsonConvert.SerializeObject(message);

            return RedirectToAction("CategoryList");
        }

        public IActionResult ProductDelete(int productId)
        {
            var entity = _productService.GetById(productId);

            if(entity != null)
            {
                _productService.Delete(entity);
            }

            var message = new AlertMessage()
            {
                Message = $"{entity.Name} silindi.",
                AlertType = "danger"
            };
            TempData["Message"] = JsonConvert.SerializeObject(message);

            return RedirectToAction("ProductList");
        }

        public IActionResult CategoryDelete(int categoryId)
        {
            var entity = _categoryService.GetById(categoryId);

            if (entity != null)
            {
                _categoryService.Delete(entity);
            }

            var message = new AlertMessage()
            {
                Message = $"{entity.Name} silindi.",
                AlertType = "danger"
            };
            TempData["Message"] = JsonConvert.SerializeObject(message);

            return RedirectToAction("CategoryList");
        }

        [HttpPost]
        public IActionResult DeleteFromCategory(int productId,int categoryId)
        {
            _categoryService.DeleteFromCategory(productId, categoryId);
            return Redirect("/admin/categories/" + categoryId);
        }
    }
}
