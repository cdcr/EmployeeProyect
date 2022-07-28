using BE;
using BE.Abstract.Interfaces.Repository;

namespace DLMongo.Repository
{
    public class ProfileMongoRepository: BaseMongoRepository<Profile>, IProfileRepository
    {
        public ProfileMongoRepository(IMongoDbRepository MongoRepository) : base(MongoRepository, "Profiles")
        {

        }
    }
}
