using Domain.Interfaces.GenericsInterfaces;
using Infra.Data.Data;
using System.Threading.Tasks;

namespace Infra.Data.Repositories.GenericsRepositories
{
    public class AddRepository<T> : IAddRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        public AddRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task InsertAsync(T obj)
        {
            await _context.AddAsync(obj);
            await _context.SaveChangesAsync();
        }
    }
}
