using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Abstract.Interfaces
{
    public interface IEmployeeFactory
    {
        Employee Build(IEmployee employeeDTO);
        List<Employee> GetEmployeeList(List<IEmployee> employeeListDTO);
        double GetAnualSalary(Employee employee);
        /*Employee Build(IEmployeeDTO employeeDTO);
        List<Employee> GetEmployeeList(List<IEmployeeDTO> employeeListDTO);
        double GetAnualSalary(Employee employee);*/
    }
}
