using Domain.Interfaces.GenericsInterfaces;
using Infra.Data.Data;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Infra.Data.Repositories.GenericsRepositories
{
    public class AddRepository<T> : IAddRepository<T>
    {
        private readonly IMongoCollection<T> _collection;

        public AddRepository(IMongoDbContext context)
        {
            _collection = context.Collection<T>();
        }

        public async Task InsertAsync(T obj)
        {
            await _collection.InsertOneAsync(obj);
        }
    }
}
