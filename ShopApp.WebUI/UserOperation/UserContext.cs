using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ShopApp.WebUI.UserOperation
{
    public class UserContext:IdentityDbContext<User>
    {
        public UserContext(DbContextOptions<UserContext> options):base(options) 
        {
             
        }
    }
}
