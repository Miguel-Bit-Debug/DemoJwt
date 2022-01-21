using AspNetCore.Identity.MongoDbCore.Models;
using System;

namespace Domain.Models
{
    public class ApplicationRole : MongoIdentityRole<Guid>
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string roleName) : base(roleName) { }
    }
}
