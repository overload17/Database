using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace Database
{
    public class DS_MONGODB : IPersonDAO
    {
        private IMongoCollection<Person> _collection;
        private MongoClient _client;
        private IMongoDatabase _db;

        public void Initialize()
        {
            string connect = "mongodb://localhost";
            _client = new MongoClient(connect);
            _db = _client.GetDatabase("local");
            _collection = _db.GetCollection<Person>("Person");
        }

        public void Create(Person p)
        {
            _collection.InsertOne(p);
        }

        public List<Person> Read()
        {
            var filter = new BsonDocument();
            var people = _collection.Find(filter).ToList();
            return people;
        }

        public void Update(Person p)
        {
            var query = Builders<Person>.Filter.Eq("Id", p.Id);
            var update = Builders<Person>.Update.Set("Lname", p.Lname).Set("Fname", p.Fname).Set("Age", p.Age);
            _collection.UpdateOne(query, update);
        }

        public void Delete(Person p)
        {
            var filter = Builders<Person>.Filter.Eq("Id", p.Id);
            _collection.DeleteOne(filter);
        }
    }
}