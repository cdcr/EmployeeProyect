﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Abstract.Interfaces
{
    public interface IEmployeeDTO:IEntityBase
    {
        string Name { get; set; }
        string ContractTypeName { get; set; }
        int RoleId { get; set; }
        string RoleName { get; set; }
        string RoleDescription { get; set; }
        double HourlySalary { get; set; }
        double MonthlySalary { get; set; }
    }
}
