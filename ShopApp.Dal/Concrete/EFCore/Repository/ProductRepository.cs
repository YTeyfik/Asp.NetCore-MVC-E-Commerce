﻿using Microsoft.EntityFrameworkCore;
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
        public List<Product> GetSearch(string search)
        {
            using (var context = new ShopContext())
            {
                var products = context
                    .Products
                    .Where(i => i.IsApproved 
                    && (i.Name.ToLower().Contains(search.ToLower()) 
                    || i.Description.ToLower().Contains(search.ToLower())))
                    .AsQueryable();

                return products.ToList();
            }
        }

        public Product GetProductDetails(string url)
        {
            using (var context = new ShopContext())
            {
                return context.Products
                    .Where(i=>i.Url==url)
                    .Include(i=>i.ProductCategories)
                    .ThenInclude(i=>i.Category)
                    .FirstOrDefault();
            }
        }


        public List<Product> GetProductsByCategory(string name, int page, int pageSize)
        {
            using (var context = new ShopContext())
            {
                var products = context
                    .Products
                    .Where(i=>i.IsApproved)
                    .AsQueryable();
               
                if (!string.IsNullOrEmpty(name))
                {
                    products= products
                        .Include(i=>i.ProductCategories)
                        .ThenInclude(i=>i.Category)
                        .Where(i=>i.ProductCategories
                        .Any(a=>a.Category.Url==name));
                }
                return products.Skip((page-1)*pageSize).Take(pageSize).ToList();
            }
        }
        public int GetCountByCategory(string category)
        {
            using (var context = new ShopContext())
            {
                var products = context
                    .Products
                    .Where(i=>i.IsApproved)
                    .AsQueryable();
                if (!string.IsNullOrEmpty(category))
                {
                    products = products
                                    .Include(i => i.ProductCategories)
                                    .ThenInclude(i => i.Category)
                                    .Where(i => i.ProductCategories.Any(a => a.Category.Url == category));
                }

                return products.Count();
            }
        }

        public List<Product> GetHomePageProducts()
        {
            using (var context = new ShopContext())
            {
                return context.Products
                    .Where(i => i.IsApproved && i.IsHome)
                    .ToList();
            }
        }
    }
}
