using BE.Abstract.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;
        protected readonly IConfiguration _configuration;

        //Context SQL
        public BaseRepository(DbContext context)
        {
            _context = context;
        }
        //Mongo Initialitation


        //Modification 
        public BaseRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // FOR SQL
        public TEntity Get(string id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }
        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
        //FOR MONGO DB 
        public void Save(TEntity entity)
        {
            throw new NotImplementedException();
        }

    }
}
