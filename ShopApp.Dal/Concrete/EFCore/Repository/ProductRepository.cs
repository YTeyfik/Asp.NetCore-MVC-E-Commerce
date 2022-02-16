using ShopApp.Dal.Abstract;
using ShopApp.Dal.Concrete.EFCore.Context;
using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Dal.Concrete.EFCore.Repository
{
    public class ProductRepository : GenericRepository<Product, ShopContext>, IProductRepository
    {
        public List<Product> GetPopularProducts()
        {
            using(var context = new ShopContext())
            {
                return context.Products.ToList();
            }
        }
    }
}
