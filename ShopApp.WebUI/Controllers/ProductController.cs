using Microsoft.AspNetCore.Mvc;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        //localhost/product/list
        public string List()
        {
            return "product/list";
        }
        //localhost/product/details
        public string Details()
        {
            return "product/list";
        }
    }
}
