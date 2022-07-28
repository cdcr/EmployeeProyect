using BE;
using BE.Abstract.Interfaces;
using BE.Abstract.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DL.Repository
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext context) : base(context)
        { }

        public List<Employee> GetEmployeeList()
        {
            throw new NotImplementedException();
        }
        public List<Employee> GetEmployeeDetailedList()
        {
            return _context.Set<Employee>()
                .Include(x => x.Profile)
                .Where(x => !x.IsDeleted)
                .ToList();
            
        }
        public void RemoveemployeeDetailed(int id)
        {
            //var Id = employee.Id==null? 0:employee.Id.Value; 
            _context.Set<Employee>().Find(id).IsDeleted = true;
            //_unitOfWork.EmployeeRepository.Get(employee.Id.Value).IsDeleted = true;
            //_unitOfWork.Complete();
        }
        public Employee GetEmployeeDetailed(int id)
        {
            return _context.Set<Employee>()
                .Include(x => x.Profile)
                .Where(x => !x.IsDeleted & x.Id==id).FirstOrDefault();
             
        }
    }

}
