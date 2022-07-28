using BE.Abstract.Interfaces;
using BE.Abstract.Interfaces.Repository;
using MongoDB.Driver;
namespace DLMongo.Repository
{
    public class MongoDbRepository: IMongoDbRepository
    {
        public MongoClient Client;
        public IMongoDatabase db { get; set; }
        public MongoDbRepository(ISystemInfo SystemInfo)
        {
            Client = new MongoClient(SystemInfo.ConnectionString);
            db = Client.GetDatabase(SystemInfo.DataBase);
        }
    }
}
