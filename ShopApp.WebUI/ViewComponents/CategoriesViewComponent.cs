using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;
using System.Collections.Generic;

namespace ShopApp.WebUI.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            var categories = new List<Category>()
            {
                new Category{ Name = "Telefonlar",Description ="Telefon Kategorisi"},
                new Category{ Name = "Bilgisayar",Description ="Bilgisayar Kategorisi"},
                new Category { Name = "Beyaz Eşya", Description = "Beyaz Eşya Kategorisi"}
            };

            return View(categories);
        }
    }
}
