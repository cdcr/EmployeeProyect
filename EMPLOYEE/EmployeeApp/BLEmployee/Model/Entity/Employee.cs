using BE;
using BE.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model.Entity
{
    public class Employee
    {
        public int? Id { get; set; }
        public int? ProfileId { get; set; }
        public string ProfileName { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public string RoleDescription { get; set; }
        public double HourlySalary { get; set; }
        public double MonthlySalary { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Profile EmployeeProfile { get; set; }


        public Employee()
        {
        }
        

    }
}
