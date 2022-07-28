using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BE.Abstract.Interfaces.Repository
{
    public interface IBaseRepository<IEntity> where IEntity : class
    {
        IEntity Get(int id);
        IEnumerable<IEntity> GetAll();
        void Add(IEntity entity);
        void Remove(IEntity entity);
        void Update(IEntity entity);
        void Save(IEntity entity);

    }
    //TEntity Get(int id);
    //IEnumerable<TEntity> GetAll();
    //void Add(TEntity entity);
    //void Remove(TEntity entity);
    //void Update(TEntity entity);
    //void Save(IEntity entity);
}
