using AspNetCore.Identity.MongoDbCore.Models;

namespace Domain.Models
{
    public class AccountModel : MongoIdentityUser
    {
        public string Avatar { get; set; }
        public bool IsAdmin { get; set; }
    }
}
