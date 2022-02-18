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
    public class CategoryRepository : GenericRepository<Category, ShopContext>, ICategoryRepository
    {
        public List<Category> GetPopularCategories()
        {
            throw new NotImplementedException();
        }
    }
}
