using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BE.Abstract.Interfaces
{
    public interface ISystemInfo
    {
        string ConnectionString { get; set; }
        string Persistence { get; set; }
        string DataBase { get; set; }
        //public string GetConnectionString();
        //public string GetDB();
        //public string GetPersistence();
        void FillSettings();
    }
}
