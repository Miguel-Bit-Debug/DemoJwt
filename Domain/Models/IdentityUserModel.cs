using Microsoft.AspNetCore.Identity;

namespace Domain.Models
{
    public class IdentityUserModel : IdentityUser
    {
        public string Avatar { get; set; }
        public bool IsAdmin { get; set; }
    }
}
