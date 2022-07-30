using BE;
using BE.Abstract.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DL.Repository
{
    public class ProfileRepository : BaseRepository<Profile>, IProfileRepository
    {
        IConfiguration _configuration;
        public ProfileRepository(DbContext context,IConfiguration configuration) : base(context){
            _configuration = configuration;
        }

        public void AddNewProfile(Profile profile)
        {
            var id = Convert.ToInt32(_configuration.GetSection("NumberOfProfiles").Value) + 1;
            profile.Id = id.ToString();
            _context.Set<Profile>().Add(profile);
        }

        public List<Profile> GetAllProfiles()
        {
            List<Profile> Profiles= _context.Set<Profile>().ToList();
            _configuration.GetSection("NumberOfProfiles").Value = Profiles.Count().ToString();
            return Profiles;

        }
    }
}
