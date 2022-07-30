using BE;
using BE.Abstract.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DL.Repository
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        protected readonly IConfiguration _configuration;
        public EmployeeRepository(DbContext context, IConfiguration configuration) : base(context)
        {
            _configuration = configuration;
        }
        public List<Employee> GetEmployeeList()
        {
            throw new NotImplementedException();
        }
        public List<Employee> GetEmployeeDetailedList()
        {
            List<Employee> Employees = _context.Set<Employee>()
                .Include(x => x.Profile).ToList();
            _configuration.GetSection("NumberOfEmployees").Value =Employees.Count().ToString();
            return Employees.Where(x => !x.IsDeleted).ToList();
            //return _context.Set<Employee>()
            //    .Include(x => x.Profile)
            //    .Where(x => !x.IsDeleted)
            //    .ToList();
        }
        public void RemoveemployeeDetailed(string id)
        {
            //var Id = employee.Id==null? 0:employee.Id.Value; 
            _context.Set<Employee>().Find(id).IsDeleted = true;
            //_unitOfWork.EmployeeRepository.Get(employee.Id.Value).IsDeleted = true;
            //_unitOfWork.Complete();
        }
        public Employee GetEmployeeDetailed(string id)
        {
            return _context.Set<Employee>()
                .Include(x => x.Profile)
                .Where(x => !x.IsDeleted & x.Id==id).FirstOrDefault();
        }

        public void AddEmployeeDetailed(Employee employee)
        {
            var id = Convert.ToInt32(_configuration.GetSection("NumberOfEmployees").Value) + 1;
            employee.Id =id.ToString();
            _context.Set<Employee>().Add(employee);
        }
    }

}
