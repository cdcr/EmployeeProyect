using System;

namespace BE.Abstract.Interfaces
{
    public interface IProfile
    {
        int? Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        int Salary { get; set; }
        DateTime DateCreated { get; set; }
        DateTime DateUpdated { get; set; }
    }
}