using ShopApp.Bll.Abstract;
using ShopApp.Dal.Abstract;
using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Bll.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;    
        }

        public void Create(Product entity)
        {
            //business logic
            _productRepository.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public List<Product> GetAll()
        {
            //iş kuralları eklenecek
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            //iş kuralları eklenecek
            return _productRepository.GetById(id);
        }

        public int GetCountByCategory(string category)
        {
            return _productRepository.GetCountByCategory(category);
        }

        public List<Product> GetHomePageProducts()
        {
            return _productRepository.GetHomePageProducts();
        }

        public Product GetProductDetails(string url)
        {
            //iş kuralları eklenecek
            return _productRepository.GetProductDetails(url);
        }

        public List<Product> GetProductsByCategory(string name, int page, int pageSize)
        {
            return _productRepository.GetProductsByCategory(name, page, pageSize);
        }

        public List<Product> GetSearch(string search)
        {
            return _productRepository.GetSearch(search);
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }
    }
}
