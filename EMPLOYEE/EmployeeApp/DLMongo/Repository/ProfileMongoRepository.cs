using BE;
using BE.Abstract.Interfaces.Repository;
using System.Collections.Generic;

namespace DLMongo.Repository
{
    public class ProfileMongoRepository: BaseMongoRepository<Profile>, IProfileRepository
    {
        public ProfileMongoRepository(IMongoDbRepository MongoRepository) : base(MongoRepository, "Profiles")
        {

        }

        public void AddNewProfile(Profile profile)
        {
            throw new System.NotImplementedException();
        }

        public List<Profile> GetAllProfiles()
        {
            throw new System.NotImplementedException();
        }
    }
}
