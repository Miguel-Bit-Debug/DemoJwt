using Domain.Interfaces.GenericsInterfaces;
using Infra.Data.Data;
using System.Threading.Tasks;

namespace Infra.Data.Repositories.GenericsRepositories
{
    public class AddRepository<T> : IAddRepository<T> where T : class
    {
        private readonly MongoDbContext _context;

        public AddRepository(MongoDbContext context)
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
