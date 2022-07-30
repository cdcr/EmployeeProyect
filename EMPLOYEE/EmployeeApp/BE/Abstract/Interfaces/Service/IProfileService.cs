using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Abstract.Interfaces.Service
{
    public interface IProfileService
    {
        List<Profile> GetEmployeeProfileListDB();
        List<Profile> GetEmployeeProfileList();
        Profile GetEmployeeProfile(string id);
        void AddEmployeeProfileDB(Profile employeeProfile);
        void UpdateEmployeeProfileDB(Profile employeeProfile);
        void RemoveEmployeeProfileDB(Profile employeeProfile);
    }
}
