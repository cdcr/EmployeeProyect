using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApp.Models.EmployeeTransforms
{
    public class Transforms
    {
        //public Transforms()
        //{
        //    _profile = new Profile();
        //    _employee = new Employee();
        //    _employeeCreateModel = new EmployeeCreateModel();
        //    _profileModel = new ProfileModel();
        //}
        public EmployeeCreateModel EmployeeToEmployeeCreateModel(Employee employee, Profile profile)
        {
            var employeeCreateModel = new EmployeeCreateModel();
            employeeCreateModel.Id = employee.Id;
            employeeCreateModel.Name = employee.Name;
            employeeCreateModel.ContractTypeName = employee.ContractTypeName;
            employeeCreateModel.ProfileId = employee.Profile.Id;
            employeeCreateModel.ProfileName = employee.Profile.Name;
            employeeCreateModel.Description = employee.RoleDescription;
            employeeCreateModel.HourlySalary = employee.HourlySalary;
            employeeCreateModel.MonthlySalary = employee.MonthlySalary;

            return employeeCreateModel;
        }
        public Employee EmployeeCreateModelToEmployee(EmployeeCreateModel employeeCreateModel, Profile profile)
        {
            var employee = new Employee()
            {
                Id = employeeCreateModel.Id,
                ContractTypeName = employeeCreateModel.ContractTypeName,
                Name = employeeCreateModel.Name,
                ProfileId = employeeCreateModel.ProfileId,
                ProfileName = profile.Name,
                RoleDescription = profile.Description,
                MonthlySalary = employeeCreateModel.HourlySalary,
                HourlySalary = employeeCreateModel.MonthlySalary
            };
            return employee;
        }
        //public Transforms(EmployeeCreateModel employeeCreateModel)
        //{
        //    _employee = new Employee()
        //    {
        //        Id = employeeCreateModel.Id,
        //        ContractTypeName = employeeCreateModel.ContractTypeName,
        //        Name = employeeCreateModel.Name,
        //        ProfileId = employeeCreateModel.Id,
        //        ProfileName = employeeCreateModel.Name,
        //        RoleDescription = employeeCreateModel.Description,
        //        MonthlySalary = employeeCreateModel.HourlySalary,
        //        HourlySalary = employeeCreateModel.MonthlySalary
        //    };
        //}
    }
}
