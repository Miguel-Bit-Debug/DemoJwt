using Infra.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUserEntity>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
    }
}
