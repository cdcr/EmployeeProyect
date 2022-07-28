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

        public UnitOfWork()
        {
        }
        public UnitOfWork(/*DbContextOptions<EmployeeContext> options*/ EmployeeContext context)
        {
            this._context = context;
            EmployeeRepository = new EmployeeRepository(_context);
            ProfileRepository = new ProfileRepository(_context);
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
