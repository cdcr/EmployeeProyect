using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Abstract.Interfaces.Service
{
    public interface IEmployeeClientService
    {
        List<Employee> GetEmployeeList();
        double GetAnualSalary(Employee employee);
    }
}
