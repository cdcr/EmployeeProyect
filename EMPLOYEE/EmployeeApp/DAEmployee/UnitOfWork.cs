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
        private EmployeeContext _context;
        private IConfiguration _configuration;
        public UnitOfWork()
        {
        }
        public UnitOfWork(/*DbContextOptions<EmployeeContext> options*/ EmployeeContext context,IConfiguration configuration)
        {
            this._context = context;
            _configuration = configuration;
            EmployeeRepository = new EmployeeRepository(_context,_configuration);
            ProfileRepository = new ProfileRepository(_context,_configuration);
        }


        public IEmployeeRepository EmployeeRepository { get; private set; }
        public IProfileRepository ProfileRepository { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public int CompleteMongo()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
