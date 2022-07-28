using BE.Abstract.Interfaces;
using BE.Abstract.Interfaces.Repository;
using System.Collections.Generic;

namespace DLMongo
{
    public class UnitOfWorkMongo : IUnitOfWork
    {

        public UnitOfWorkMongo(IEmployeeRepository employeeMongoRepository, IProfileRepository profileMongoRepository)
        {
            this.EmployeeRepository = employeeMongoRepository;
            this.ProfileRepository = profileMongoRepository;
        }

        public IEmployeeRepository EmployeeRepository { get; private set; }
        public IProfileRepository ProfileRepository { get; private set; }
        public int Complete()
        {
            throw new System.NotImplementedException();
        }
        public int CompleteMongo()
        {
            return 1;
        }
        public void Dispose(){}
    }
}
