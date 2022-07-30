using BE;
using BE.Abstract.Interfaces.Repository;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DLMongo.Repository
{
    public class EmployeeMongoRepository:BaseMongoRepository<Employee>, IEmployeeRepository
    {
        public EmployeeMongoRepository(IMongoDbRepository MongoRepository) : base(MongoRepository, "Employees")
        {

        }

        public void AddEmployeeDetailed(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public Employee GetEmployeeDetailed(string id)
        {
            throw new System.NotImplementedException();
        }
    
        public List<Employee> GetEmployeeDetailedList()
        {
            throw new System.NotImplementedException();
        }
        public List<Employee> GetEmployeeList()
        {
            throw new System.NotImplementedException();
        }
        public void RemoveemployeeDetailed(string id)
        {
            throw new System.NotImplementedException();
        }
    }
    
}
