using Domain.Interfaces;
using Infra.Data.Data;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Data.Repositories.GenericsRepositories
{
    public class ListRepository<T> : IListRepository<T>
    {
        private readonly IMongoCollection<T> _collection;

        public ListRepository(IMongoDbContext context)
        {
            _collection = context.Collection<T>();
        }

        public async Task<IEnumerable<T>> List()
        {
            var products = await _collection.FindAsync(obj => true).Result.ToListAsync();
            return products;
        }
    }
}
