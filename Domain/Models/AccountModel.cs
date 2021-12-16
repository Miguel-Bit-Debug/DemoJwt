using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;
using System;

namespace Domain.Models
{
    [CollectionName("Account")]
    public class AccountModel : MongoIdentityUser<Guid>
    {
        public string Avatar { get; set; }
        public bool IsAdmin { get; set; }
    }
}
