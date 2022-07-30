using BE.Abstract.Interfaces.Repository;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DLMongo.Repository
{
    public class BaseMongoRepository<IEntity> : IBaseRepository<IEntity> where IEntity : class
    {
        readonly IMongoDbRepository _repository;
        public readonly IMongoCollection<IEntity> Collection;
        public BaseMongoRepository(IMongoDbRepository repository, string CollectionName)
        {
            //_repository = repository;
            Collection = repository.db.GetCollection<IEntity>(CollectionName);
        }
        public IEntity Get(string id)
        {
            var filter = Builders<IEntity>.Filter.Eq("Id", id.ToString());
            return Collection.Find(filter).FirstOrDefault();
        }
        public IEnumerable<IEntity> GetAll()
        {
            var coll= Collection.Find(new BsonDocument()).ToList();
            return coll;

        }
        public void Add(IEntity entity)
        {
            var filter = Builders<IEntity>.Filter.Eq("Id", entity.ToString());
            var selectedEntity = Collection.Find(filter).FirstOrDefault();
            if (selectedEntity != null)
                Collection.ReplaceOne(filter, entity);
            else
                Collection.InsertOne(entity);
        }
        public void Save(IEntity entity)
        {
            var filter = Builders<IEntity>.Filter.Eq("Id", entity.ToString());
            var selectedEntity = Collection.Find(filter).FirstOrDefault();
            if (selectedEntity != null)
                Collection.ReplaceOne(filter, entity);
            else
                Collection.InsertOne(entity);
        }
        public void Remove(IEntity entity)
        {
            var filter = Builders<IEntity>.Filter.Eq("Id", entity.ToString());
            Collection.DeleteOne(filter);
        }
        //------SQL MONGO-----------------
        public void Update(IEntity entity)
        {
            var filter = Builders<IEntity>.Filter.Eq("Id", entity.ToString());
            Collection.ReplaceOne(filter,entity);
        }
        
    }
}
