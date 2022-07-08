using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Abstract.Interfaces
{
    public interface IEmployeeFactory
    {
        Employee Build(IEmployeeDTO employeeDTO);
        List<Employee> GetEmployeeList(List<IEmployeeDTO> employeeListDTO);
        double GetAnualSalary(Employee employee);
    }
}
