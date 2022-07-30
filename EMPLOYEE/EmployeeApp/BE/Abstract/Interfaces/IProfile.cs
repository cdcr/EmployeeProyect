using System;

namespace BE.Abstract.Interfaces
{
    public interface IProfile:IEntityBase
    {
        string Name { get; set; }
        string Description { get; set; }
        int Salary { get; set; }
        DateTime DateCreated { get; set; }
        DateTime DateUpdated { get; set; }
    }
}