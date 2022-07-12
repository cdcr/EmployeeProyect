using BE.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Employee: IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public double HourlySalary { get; set; }
        public double MonthlySalary { get; set; }

        public Employee()
        {
        }
        public Employee(IEmployee DTO)
        {
            ID = DTO.ID;
            Name = DTO.Name;
            ContractTypeName = DTO.ContractTypeName;
            RoleId = DTO.RoleId;
            RoleName = DTO.RoleName;
            RoleDescription = DTO.RoleDescription;
            HourlySalary = DTO.HourlySalary;
            MonthlySalary = DTO.MonthlySalary;
        }

    }

}
