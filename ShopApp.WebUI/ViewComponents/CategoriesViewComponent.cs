using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ShopApp.WebUI.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            //if (RouteData.Values["action"].ToString() == "List")
            //{
            //    ViewBag.SelectedCategory = RouteData?.Values["id"];
            //}
            //return View(ICategoryRepository);
            return View();
        }
    }
}
