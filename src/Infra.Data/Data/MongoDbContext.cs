using Domain.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;

namespace Infra.Data.Data
{
    public class MongoDbContext : IMongoDbContext
    {
        private readonly IMongoDatabase _database;

        public IClientSessionHandle Session { get; set; }

        public MongoDbContext(IConfiguration configuration)
        {
            var mongoClient = new MongoClient(configuration["DbConnection"]);
            _database = mongoClient.GetDatabase("application");
        }

        public IMongoCollection<T> Collection<T>()
        {
            return _database.GetCollection<T>(typeof(T).Name);
        }

        public IMongoCollection<T> Collection<T>(string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }

        public void Dispose()
        {
            Session?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
