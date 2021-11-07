using Microsoft.AspNetCore.Identity;

namespace Infra.Data.Entities
{
    public class UserLoginEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
