using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShopApp.Bll.Abstract;
using ShopApp.Bll.Concrete;
using ShopApp.Dal.Abstract;
using ShopApp.Dal.Concrete.EFCore.Repository;
using ShopApp.Dal.Concrete.EFCore.Test;
using ShopApp.WebUI.UserOperation;
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
            services.AddDbContext<UserContext>(options => options.UseSqlite("Data Source=ShopDb"));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<UserContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                //Password
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase=false;
                options.Password.RequiredLength = 6;
                
                //LockOut
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
                options.Lockout.AllowedForNewUsers = true;

                //user
                options.User.RequireUniqueEmail = true;
                //sign in
                //burasý mail onayý ve telefon onayý yapýlmýþmý diye kontrol ediyor
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;

            });

            //cookie yönetimi
            services.ConfigureApplicationCookie(options => {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true; //burasý client istek yapmazsa 20 dakka sonra cookieleri silip login sayfasýna gönderiyor
                options.ExpireTimeSpan= TimeSpan.FromDays(90); //90 gün boyunca tanýnacaðýný belirttik
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true, //http request ile alýnýr
                    Name =".ShopApp.Cookie"
                };

            });

            //DependecyInjection iþlemi
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
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
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            //localhost:5000
            //localhost:5000/products
            app.UseEndpoints(endpoints =>
            {
                //Buranýn sýrasý önemli daha doðrusu önemli olanlar üste alýnmalý yada gruplanmalý

                endpoints.MapControllerRoute(
                    name: "search",
                    pattern: "search",
                    defaults: new { controller = "Shop", action = "search" }
                );
                //burasý shop/list e giderken browserda product isminde gözükecek
                endpoints.MapControllerRoute(
                    name: "products",
                    pattern: "products/{category?}",
                    defaults: new { controller = "Shop", action = "list" }
                );
                endpoints.MapControllerRoute(
                  name: "adminproducts",
                  pattern: "admin/products",
                  defaults: new { controller = "Admin", action = "ProductList" }
                );
                endpoints.MapControllerRoute(
                name: "adminproductcreate",
                pattern: "admin/products/create",
                defaults: new { controller = "Admin", action = "ProductCreate" }
                );
                endpoints.MapControllerRoute(
                  name: "adminproductedit",
                  pattern: "admin/products/{id?}",
                  defaults: new { controller = "Admin", action = "ProductEdit" }
                );
                endpoints.MapControllerRoute(
                name: "admincategories",
                pattern: "admin/categories",
                defaults: new { controller = "Admin", action = "CategoryList" }
                );
                endpoints.MapControllerRoute(
                name: "admincategorycreate",
                pattern: "admin/categories/create",
                defaults: new { controller = "Admin", action = "CategoryCreate" }
                );
                endpoints.MapControllerRoute(
                  name: "admincategoryedit",
                  pattern: "admin/categories/{id?}",
                  defaults: new { controller = "Admin", action = "CategoryEdit" }
                );

                endpoints.MapControllerRoute(
                    name: "productdetails",
                    pattern: "{url}",
                    defaults: new { controller = "Shop", action = "details" }
                );
                

                endpoints.MapControllerRoute(
                        name: "default",
                        //{controller=Home}/{action=Index} default routing 
                        pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
