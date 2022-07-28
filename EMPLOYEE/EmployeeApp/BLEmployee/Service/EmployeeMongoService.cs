using BE;
using BE.Abstract.Interfaces;
using BE.Abstract.Interfaces.Repository;
using BE.Abstract.Interfaces.Service;
using DLService.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL.Service
{
    public class EmployeeMongoService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;
        private readonly IEmployeeRepository _employeeClientRepository;

        public EmployeeMongoService(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
            _employeeClientRepository = new EmployeeClientRepository(_configuration);
        }
        public List<Employee> GetEmployeeListDB()
        {
            return _unitOfWork.EmployeeRepository.GetAll().ToList();
        }
        //Servicio
        public List<Employee> GetEmployeeList()
        {
            var FromDB = Convert.ToBoolean(_configuration.GetSection("FromDB").Value);
            var employees = FromDB == true ?
                         _unitOfWork.EmployeeRepository.GetAll().ToList() :
                         _employeeClientRepository.GetEmployeeList();
            return employees;
        }
        //----------no usado
        public List<Employee> GetEmployeeListService()
        {
            return _unitOfWork.EmployeeRepository.GetEmployeeList();
        }
        ///
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
            var ProfileDocuments =  _unitOfWork.ProfileRepository.GetAll();
            List<Employee> result = new List<Employee>();
            ProfileDocuments.ToList().ForEach(item => result.AddRange(item.Employees.ToList()));
            return result;
        }
        public Employee GetEmployeeDetailedDB(int id)
        {
            var EmployeeList = GetEmployeeDetailedListDB();
            return EmployeeList.FirstOrDefault(item => item.Id == id);
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
            var currentEmployee = GetEmployeeDetailedDB(employee.Id.GetValueOrDefault());
            var currentProfile = _unitOfWork.ProfileRepository.Get(employee.ProfileId.GetValueOrDefault());
            if (currentProfile.Employees.Any(item => item.Id == employee.Id))
                currentProfile.Employees.Remove(currentEmployee);
            currentProfile.Employees.Add(employee);
            //_unitOfWork.ProfileRepository.Save(currentProfile);
            //_unitOfWork.EmployeeRepository.Add(employee);
            _unitOfWork.Complete();
        }

        public void UpdateDetailedEmployeeDB(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Update(employee);
            _unitOfWork.Complete();
        }
    }
}
