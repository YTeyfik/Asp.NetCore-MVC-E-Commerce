using Microsoft.EntityFrameworkCore;
using ShopApp.Dal.Concrete.EFCore.Context;
using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Dal.Concrete.EFCore.Test
{
    public static class TestDataBase
    {
        //migration yoksa test verilerini getirir
        public static void Test()
        {
            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                }
            }
            context.SaveChanges();
        }

        private static Category[] Categories = {
            new Category(){Name="Telefon"},
            new Category(){Name="Bilgisayar"},
            new Category(){Name="Elektronik"}
        };

        private static Product[] Products = {
            new Product(){Name="IPhone 7",Price=3200,ImageUrl="1.jpg",Description="32 GB", IsApproved=true},
            new Product(){Name="IPhone 8",Price=4500,ImageUrl="2.jpg",Description="32 GB", IsApproved=false},
            new Product(){Name="IPhone X",Price=7000,ImageUrl="3.jpg",Description="64 GB", IsApproved=true},
            new Product(){Name="IPhone 11",Price=9000,ImageUrl="4.png",Description="128 GB", IsApproved=false},
            
        };
    }
}
