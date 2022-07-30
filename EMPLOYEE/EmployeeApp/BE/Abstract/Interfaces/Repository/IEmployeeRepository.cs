using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Abstract.Interfaces.Repository
{
    public interface IEmployeeRepository:IBaseRepository<Employee>
    {
        List<Employee> GetEmployeeList();
        List<Employee> GetEmployeeDetailedList();
        Employee GetEmployeeDetailed(string id);
        void RemoveemployeeDetailed(string id);
        void AddEmployeeDetailed(Employee employee);
    }
}
