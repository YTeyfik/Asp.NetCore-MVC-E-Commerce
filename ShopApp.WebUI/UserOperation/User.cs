using Microsoft.AspNetCore.Identity;

namespace ShopApp.WebUI.UserOperation
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
