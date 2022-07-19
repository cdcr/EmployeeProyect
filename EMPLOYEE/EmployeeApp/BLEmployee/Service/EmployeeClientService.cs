using BE;
using BE.Abstract.Interfaces;
using BE.Abstract.Interfaces.Repository;
using BE.Abstract.Interfaces.Service;
using DL;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Service
{
    public class EmployeeClientService : IEmployeeClientService
    {
        private readonly IConfiguration _configuration;
        private readonly IEmployeeFactory _employeeFact;
        private EmployeeContext _employeeContext;
        //private  IUnitOfWork _unitOfWork;


        public EmployeeClientService(IEmployeeFactory employeeFact,
                                     IConfiguration configuration,
                                     /*IUnitOfWork unitOfWork,*/
                                     EmployeeContext employeecontext)
        {
            _configuration = configuration;
            _employeeFact = employeeFact;
            _employeeContext = employeecontext;
            //_unitOfWork = unitOfWork;
        }

        public double GetAnualSalary(Employee employee)
        {
            try
            {
                return _employeeFact.GetAnualSalary(employee);
            }
            catch (Exception ex)
            {
                ex.Data.Add("EmployeeClientService", "GetAnualSalary()");
                throw ex;
            }

        }
        public List<Employee> GetEmployeeListDB()
        {
            try
            {

                var _unitOfWork = new UnitOfWork(_employeeContext);
                //_unitOfWork = new UnitOfWork(_employeeContext);
                return _employeeFact.GetEmployeeList(_unitOfWork.EmployeeRepository.GetAll().Cast<IEmployee>().ToList());
            }
            catch (Exception ex)
            {
                ex.Data.Add("EmployeeClientService", "GetEmployeeList()");
                throw ex;
            }
        }
    }
    /***public List<Employee> GetEmployeeList()
    {
        try
        {

            var _unitOfWork = new UnitOfWork(null/*,_configuration/);
            //TODO: Llamar a UnitOfWork 
                //Llamar directa al repositorio:
            //return _employeeFact.GetEmployeeList(_unitOfWork.EmployeeClientRepository.GetEmployeeList());
            return _employeeFact.GetEmployeeList(_unitOfWork.EmployeeRepository.GetAll().Cast<IEmployee>().ToList());
            //Llamada por medio de UnitOfWork
            //return EmployeeFact.GetEmployeeList(EmployeeClientRepo.GetEmployeeList());
        }
        catch (Exception ex)
        {
            ex.Data.Add("EmployeeClientService", "GetEmployeeList()");
            throw ex;
        }
    }*/




}
