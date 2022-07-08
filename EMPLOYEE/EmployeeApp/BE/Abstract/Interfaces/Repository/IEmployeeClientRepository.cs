using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Abstract.Interfaces.Repository
{
    public interface IEmployeeClientRepository
    {
       List<IEmployeeDTO> GetEmployeeList();
    }
}
