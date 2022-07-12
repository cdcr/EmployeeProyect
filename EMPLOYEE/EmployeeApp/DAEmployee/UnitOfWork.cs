using BE.Abstract.Interfaces;
using BE.Abstract.Interfaces.Repository;
using DL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        public readonly IConfiguration _configuration;
        public UnitOfWork(DbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
            EmployeeClientRepository = new EmployeeClientRepository(_configuration);
            EmployeeRepository = new EmployeeRepository(_context);
            
        }
        
        public IEmployeeRepository EmployeeRepository { get; private set; }
        public IEmployeeClientRepository EmployeeClientRepository { get; private set; }

        //Modification
        /*public UnitOfWork(IConfiguration iconfiguration)
        {
            //_iconfiguration = iconfiguration;
            //EmployeeClientRepository = new EmployeeClientRepository(_iconfiguration);
        }
        //--
        */
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
