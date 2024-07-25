using Microsoft.AspNetCore.Identity;

namespace Amazon.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
