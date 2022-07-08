using BE;
using BE.Abstract.Interfaces;
using BE.Abstract.Interfaces.Repository;
using BE.Abstract.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Service
{
    public class EmployeeClientService : IEmployeeClientService
    {
        private IEmployeeFactory EmployeeFact;
        private IEmployeeClientRepository EmployeeClientRepo;
        public EmployeeClientService(IEmployeeFactory _EmployeeFact, IEmployeeClientRepository _EmployeeClientRepo)
        {
            EmployeeFact = _EmployeeFact;
            EmployeeClientRepo = _EmployeeClientRepo;
        }

        public double GetAnualSalary(Employee employee)
        {
            try
            {
                return EmployeeFact.GetAnualSalary(employee);
            }
            catch (Exception ex)
            {
                ex.Data.Add("EmployeeClientService", "GetAnualSalary()");
                throw ex;
            }
            
        }

        public List<Employee> GetEmployeeList()
        {
            try
            {
                //TODO: Llamar a UnitOfWork 
                return EmployeeFact.GetEmployeeList(EmployeeClientRepo.GetEmployeeList());
            }
            catch (Exception ex)
            {
                ex.Data.Add("EmployeeClientService", "GetEmployeeList()");
                throw ex;
            }
        }

    }
}
