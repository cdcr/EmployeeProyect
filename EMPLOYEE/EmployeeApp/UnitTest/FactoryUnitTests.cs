using BE;
using BE.Abstract.Interfaces;
using Core.Factory;
using NUnit.Framework;
using System.Collections.Generic;


namespace UnitTest
{

    public class FactoryUnitTests
    {
        EmployeeFactory employeeFactory;
        Employee employee;
        Employee employeeDTO;
        

        [Test]
        public void GetAnualSalary_HourlySalary_MatchSalaries()
        {
            var anualSalaryByHour = 120 * employee.HourlySalary * 12;
            employee.ContractTypeName = "HourlySalaryEmployee";
            Assert.AreEqual(employeeFactory.GetAnualSalary(employee), anualSalaryByHour);
        }

        [Test]
        public void GetAnualSalary_MonthlySalary_MatchSalaries()
        {
            var anualSalaryByMonth = employee.MonthlySalary * 12;
            employee.ContractTypeName = "MonthlySalaryEmployee";
            Assert.AreEqual(employeeFactory.GetAnualSalary(employee), anualSalaryByMonth);
        }

        /// <summary>
        /// This section tests the factory conversion from one object to another 
        /// </summary>
        [Test]
        public void GetEmployeeList_EmployeeDTOList_EmployeeEntityTypeMatch()
        {
            var EmployeeDTOList = new List<IEmployee>{employeeDTO};
            var employeeList = employeeFactory.GetEmployeeList(EmployeeDTOList);
            Assert.AreEqual(employeeList.GetType(), typeof(List<Employee>));
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            employeeFactory = new EmployeeFactory();
            employee = employeeFactory.Create();
            employee.Id = 1;
            employee.Name = "John Smith";
            employee.ProfileId = 1;
            employee.ProfileName = "Administrator";
            employee.RoleDescription = "General Administrator";
            employee.HourlySalary = 20;
            employee.MonthlySalary = 4000;

            employeeDTO = new Employee
            {
                Id = 1,
                Name = "John Smith",
                ProfileId = 1,
                ProfileName = "Administrator",
                RoleDescription = "General Administrator",
                HourlySalary = 20,
                MonthlySalary = 4000
            };
        }
    }
}
