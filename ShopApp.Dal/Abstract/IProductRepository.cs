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
        List<Product> GetPopularProducts();
    }
}
