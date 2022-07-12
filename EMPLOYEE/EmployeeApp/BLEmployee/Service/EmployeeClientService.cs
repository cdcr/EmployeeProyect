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
        //private readonly IUnitOfWork _unitOfWork;


        public EmployeeClientService(IEmployeeFactory employeeFact,  
                                     IConfiguration configuration/*, IUnitOfWork unitOfWork*/)
        {
            _configuration = configuration;
            _employeeFact = employeeFact;
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

        public List<Employee> GetEmployeeList()
        {
            try
            {
                
                var _unitOfWork = new UnitOfWork(null,_configuration);
                //TODO: Llamar a UnitOfWork 
                    //Llamar directa al repositorio:
                return _employeeFact.GetEmployeeList(_unitOfWork.EmployeeClientRepository.GetEmployeeList());
                    //Llamada por medio de UnitOfWork
                //return EmployeeFact.GetEmployeeList(EmployeeClientRepo.GetEmployeeList());
            }
            catch (Exception ex)
            {
                ex.Data.Add("EmployeeClientService", "GetEmployeeList()");
                throw ex;
            }
        }

        public List<Employee> GetEmployeeListDB()
        {
            try
            {

                var _unitOfWork = new UnitOfWork(new EmployeeContext(),null) ;
                //TODO: Llamar a UnitOfWork 
                //Llamar del servicio
                //return EmployeeFact.GetEmployeeList(unit.EmployeeClientRepository.GetEmployeeList());
                //List<IEmployeeDTO> employeeListDTO = unit.EmployeeRepository.GetAll().Cast<IEmployeeDTO>().ToList();
                //Llamar de la base de datos
                return _employeeFact.GetEmployeeList(_unitOfWork.EmployeeRepository.GetAll().Cast<IEmployeeDTO>().ToList());
                //return EmployeeFact.GetEmployeeList(EmployeeClientRepo.GetEmployeeList());
            }
            catch (Exception ex)
            {
                ex.Data.Add("EmployeeClientService", "GetEmployeeList()");
                throw ex;
            }
        }

    }
}
