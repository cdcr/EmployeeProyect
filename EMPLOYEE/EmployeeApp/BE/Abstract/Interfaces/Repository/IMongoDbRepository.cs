using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Abstract.Interfaces.Repository
{
    public interface IMongoDbRepository
    {
        IMongoDatabase db { get; set; }
    }
}
