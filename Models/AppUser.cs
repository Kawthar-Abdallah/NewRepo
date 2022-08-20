using Microsoft.AspNetCore.Identity;

namespace CMS.Models
{
    public class AppUser : IdentityUser
    {
        public string Occupation { get; set; }
    }
}