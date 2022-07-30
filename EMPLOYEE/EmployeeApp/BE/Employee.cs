using BE.Abstract.Interfaces;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace BE
{
    public class Employee: IEmployee
    {
        [BsonId]
        [Key]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string ProfileId { get; set; }
        public string ProfileName { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public string RoleDescription { get; set; }
        public double HourlySalary { get; set; }
        public double MonthlySalary { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Profile Profile { get; set; }


        public Employee()
        {
        }
        public Employee(IEmployee DTO)
        {
            Id = DTO.Id;
            Name = DTO.Name;
            ContractTypeName = DTO.ContractTypeName;
            ProfileId = DTO.ProfileId;
            ProfileName = DTO.ProfileName;
            RoleDescription = DTO.RoleDescription;
            HourlySalary = DTO.HourlySalary;
            MonthlySalary = DTO.MonthlySalary;
        }

    }

}
