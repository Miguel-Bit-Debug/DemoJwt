﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDbGenericRepository.Attributes;
using System;

namespace Domain.Models
{
    [CollectionName("Product")]
    public class Product
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Likes { get; set; }
    }
}
