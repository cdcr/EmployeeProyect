using BE.Abstract.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Abstract.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        #region SQL
        //IEmployeeClientRepository EmployeeClientRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }
        IProfileRepository ProfileRepository { get; }
        //IEmployeeRepository EmployeeClientRepository { get; }
        int Complete();
        #endregion

    }
}
