using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Abstract.Interfaces.Service
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployeeListDB();
        List<Employee> GetEmployeeListService();
        List<Employee> GetEmployeeList();
        Employee GetEmployee(int id);
        double GetAnualSalary(Employee employee);
        void AddEmployeeDB(Employee employee);
        void UpdateEmployeeDB(Employee employee);
        void RemoveemployeeDB(Employee employee);
        ///-Detailed Methods
        List<Employee> GetEmployeeDetailedListDB();
        Employee GetEmployeeDetailedDB(int id);
        void AddEmployeeDetailedDB(Employee employee);
        void UpdateDetailedEmployeeDB(Employee employee);
        void RemoveemployeeDetailedDB(Employee employee);
    }
}
