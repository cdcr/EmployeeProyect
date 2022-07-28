using BE;
using BE.Abstract.Interfaces.Repository;
using System.Collections.Generic;

namespace DLMongo.Repository
{
    public class EmployeeMongoRepository:BaseMongoRepository<Employee>, IEmployeeRepository
    {
        public EmployeeMongoRepository(IMongoDbRepository MongoRepository) : base(MongoRepository, "Employees")
        {

        }
        public Employee GetEmployeeDetailed(int id)
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
        public void RemoveemployeeDetailed(int id)
        {
            throw new System.NotImplementedException();
        }
    }
    
}
