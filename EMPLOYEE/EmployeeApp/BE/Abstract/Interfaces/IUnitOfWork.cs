using BE.Abstract.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Abstract.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository EmployeeRepository { get; }
        int Complete();
    }
}
