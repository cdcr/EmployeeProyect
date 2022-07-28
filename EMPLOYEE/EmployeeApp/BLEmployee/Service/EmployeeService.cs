using BE;
using BE.Abstract.Interfaces;
using BE.Abstract.Interfaces.Repository;
using BE.Abstract.Interfaces.Service;
using DLService.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;
        private readonly IEmployeeRepository _employeeClientRepository;

        public EmployeeService(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
            _employeeClientRepository = new EmployeeClientRepository(_configuration);
        }
        public List<Employee> GetEmployeeListDB()
        {
            return _unitOfWork.EmployeeRepository.GetAll().ToList();
        }
        public List<Employee> GetEmployeeList()
        {
            var FromDB = Convert.ToBoolean(_configuration.GetSection("FromDB").Value);
            var employees = FromDB == true ?
                         _unitOfWork.EmployeeRepository.GetAll().ToList() :
                         _employeeClientRepository.GetEmployeeList();
            return employees;
        }
        public List<Employee> GetEmployeeListService()
        {
            return _unitOfWork.EmployeeRepository.GetEmployeeList();
        }
        public Employee GetEmployee(int id)
        {
            return _unitOfWork.EmployeeRepository.Get(id);
        }
        public void AddEmployeeDB(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Add(employee);
            _unitOfWork.Complete();
        }
        public void UpdateEmployeeDB(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Update(employee);
            _unitOfWork.Complete();
        }
        public double GetAnualSalary(Employee employee)
        {
            try
            {
                if (employee.ContractTypeName == "HourlySalaryEmployee")
                {
                    return 12 * employee.HourlySalary * 120;
                }
                else if (employee.ContractTypeName == "MonthlySalaryEmployee")
                {
                    return 12 * employee.MonthlySalary;
                }
                else
                    return 0;
            }
            catch (Exception ex)
            {
                ex.Data.Add("EmployeeFactory", "GetAnualSalary()");
                throw ex;
            }

        }
        public void RemoveemployeeDB(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Remove(employee);
            _unitOfWork.Complete();
        }


        //DETAILED METHODS -----------------------------------------
        public List<Employee> GetEmployeeDetailedListDB()
        {
            var FromDB = Convert.ToBoolean(_configuration.GetSection("FromDB").Value);
            var employees = FromDB == true ?
                _unitOfWork.EmployeeRepository.GetEmployeeDetailedList():
                _employeeClientRepository.GetEmployeeList();
            return employees;

        }
        public Employee GetEmployeeDetailedDB(int id)
        {
            return _unitOfWork.EmployeeRepository.GetEmployeeDetailed(id);
        }
        public void RemoveemployeeDetailedDB(Employee employee)
        {
            //var Id = employee.Id==null? 0:employee.Id.Value; 
            //_unitOfWork.EmployeeRepository.Get(employee.Id.Value).IsDeleted=true;
            _unitOfWork.EmployeeRepository.RemoveemployeeDetailed(employee.Id.Value);
            _unitOfWork.Complete();
        }

        public void AddEmployeeDetailedDB(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Add(employee);
            _unitOfWork.Complete();
        }

        public void UpdateDetailedEmployeeDB(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Update(employee);
            _unitOfWork.Complete();
        }
    }
}
