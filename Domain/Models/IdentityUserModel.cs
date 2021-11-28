using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class IdentityUserModel : IdentityUser
    {
        public string Avatar { get; set; }
        public bool IsAdmin { get; set; }
    }
}
