using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShopApp.Bll.Abstract;
using ShopApp.Bll.Concrete;
using ShopApp.Dal.Abstract;
using ShopApp.Dal.Concrete.EFCore.Repository;
using ShopApp.Dal.Concrete.EFCore.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //DependecyInjection iþlemi
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //Burasý eðer db boþsa ve migration beklemiyorsa test verilerini getiriyor
                TestDataBase.Test();
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles(); // wwwroot altýndaki klasörler açýlýr            
            app.UseRouting();

            //localhost:5000
            //localhost:5000/products
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                        name: "default",
                        //{controller=Home}/{action=Index} default routing 
                        pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
