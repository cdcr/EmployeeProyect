using BE;
using BE.Abstract.Interfaces;
using BE.Abstract.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL.Service
{
    public class ProfileMongoService : IProfileService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProfileMongoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<Profile> GetEmployeeProfileListDB()
        {
            return _unitOfWork.ProfileRepository.GetAll().ToList();
        }
        public List<Profile> GetEmployeeProfileList()
        {
            var employeeProfiles = _unitOfWork.ProfileRepository.GetAll().ToList();
            return employeeProfiles;
        }

        public Profile GetEmployeeProfile(string id)
        {
            return _unitOfWork.ProfileRepository.Get(id);
        }
        public void AddEmployeeProfileDB(Profile employeeProfile)
        {
            _unitOfWork.ProfileRepository.Add(employeeProfile);
            _unitOfWork.Complete();
        }
        public void UpdateEmployeeProfileDB(Profile employeePrfofile)
        {
            _unitOfWork.ProfileRepository.Update(employeePrfofile);
            _unitOfWork.Complete();
        }
        public void RemoveEmployeeProfileDB(Profile employeeProfile)
        {
            _unitOfWork.ProfileRepository.Remove(employeeProfile);
            _unitOfWork.Complete();
        }
    }
}
