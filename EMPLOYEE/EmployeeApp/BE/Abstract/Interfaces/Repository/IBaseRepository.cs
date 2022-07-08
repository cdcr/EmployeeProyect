using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Abstract.Interfaces.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void Remove(TEntity entity);
    }

}
