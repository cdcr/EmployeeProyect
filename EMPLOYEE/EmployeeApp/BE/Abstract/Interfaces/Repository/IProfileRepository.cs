using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Abstract.Interfaces.Repository
{
    public interface IProfileRepository:IBaseRepository<Profile>
    {
        void AddNewProfile(Profile profile);
        List<Profile> GetAllProfiles();
    }
}
