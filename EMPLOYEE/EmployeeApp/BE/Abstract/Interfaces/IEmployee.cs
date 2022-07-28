using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Abstract.Interfaces
{
    public interface IEmployee
    {
        int? Id { get; set; }
        int? ProfileId { get; set; }
        string ProfileName { get; set; }
        string Name { get; set; }
        string ContractTypeName { get; set; }
        string RoleDescription { get; set; }
        double HourlySalary { get; set; }
        double MonthlySalary { get; set; }
        bool IsDeleted { get; set; }
    }
}
