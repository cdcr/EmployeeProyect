using BE;
using BE.Abstract.Interfaces;
using BE.Abstract.Interfaces.Service;
using System.Collections.Generic;
using System.Linq;

namespace BL.Service
{
    public class ProfileService:IProfileService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProfileService(IUnitOfWork unitOfWork)
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

        public Profile GetEmployeeProfile(int id)
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

