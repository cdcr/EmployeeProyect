using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Abstract.Interfaces.Repository
{
    public interface IEmployeeRepository:IBaseRepository<Employee>
    {
        List<Employee> GetEmployeeList();
        List<Employee> GetEmployeeDetailedList();
        Employee GetEmployeeDetailed(int id);
        void RemoveemployeeDetailed(int id);
    }
}
