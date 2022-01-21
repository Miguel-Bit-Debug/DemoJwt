using MongoDB.Driver;
using System;

namespace Infra.Data.Data
{
    public interface IMongoDbContext : IDisposable
    {
        IMongoCollection<T> Collection<T>();
        IMongoCollection<T> Collection<T>(string collectionName);
    }
}
