using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApp.Models
{
    public class EmployeeCreateModel
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
        public List<Profile> Profiles {get; set;}

    }

}
