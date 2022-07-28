
using BE;
using System.ComponentModel.DataAnnotations;

namespace EmployeeApp.Models
{
    public class EmployeeModel
    {
        public int? Id { get; set; }
        [Display(Name = "Profile Id")]
        public int? ProfileId { get; set; }
        [Display(Name = "Profile Name")]
        public string ProfileName { get; set; }
        public string Name { get; set; }
        [Display(Name = "Contract Type")]
        public string ContractTypeName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        public double HourlySalary { get; set; }
        public double MonthlySalary { get; set; }

        [Display(Name = "Anual Salary")]
        [DataType(dataType: DataType.Currency)]
        public double AnualSalary { get; set; }

        public EmployeeModel(Employee employee, double anualSalary)
        {
            Id = employee.Id;
            Name = employee.Name;
            ContractTypeName = employee.ContractTypeName;
            Description = employee.Profile == null ?
                employee.RoleDescription:employee.Profile.Description;
            HourlySalary = employee.HourlySalary;
            MonthlySalary = employee.MonthlySalary;
            AnualSalary = anualSalary;
            ProfileId = employee.Profile == null ?
                employee.ProfileId:
                employee.Profile.Id;
            ProfileName = employee.Profile == null ?
                employee.ProfileName :
                employee.Profile.Name;
        }

    }
}
