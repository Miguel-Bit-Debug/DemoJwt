using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUserModel>
    {
        public DbSet<ProductModel> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
    }
}
