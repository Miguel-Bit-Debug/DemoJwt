using Microsoft.AspNetCore.Identity;

namespace Infra.Data.Entities
{
    public class IdentityUserEntity : IdentityUser
    {
        public string Avatar { get; set; }
        public bool IsAdmin { get; set; }
    }
}
