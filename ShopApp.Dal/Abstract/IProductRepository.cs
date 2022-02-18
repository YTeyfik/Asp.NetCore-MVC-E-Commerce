using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Dal.Abstract
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        List<Product> GetSearch(string search);
        Product GetProductDetails(string url);
        List<Product> GetHomePageProducts();
        List<Product> GetProductsByCategory(string name, int page, int pageSize);
        int GetCountByCategory(string category);
    }
}
