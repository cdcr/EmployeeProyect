using BE;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DL
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(){}
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        
        //public DbSet<EmployeeDTO> EmployeesDTO { get; set; }
    }
}
