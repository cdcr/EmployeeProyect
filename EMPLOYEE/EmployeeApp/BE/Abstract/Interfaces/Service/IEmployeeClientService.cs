using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Abstract.Interfaces.Service
{
    public interface IEmployeeClientService
    {
        List<Employee> GetEmployeeList();
        List<Employee> GetEmployeeListDB();

        double GetAnualSalary(Employee employee);
    }
}
