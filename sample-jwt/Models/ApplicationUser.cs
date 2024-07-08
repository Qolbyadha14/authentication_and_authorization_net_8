using Microsoft.AspNetCore.Identity;
using sample_jwt.Enums;

namespace sample_jwt.Models
{
    public class ApplicationUser : IdentityUser
    {
        public Role Role { get; set; }
    }
}
