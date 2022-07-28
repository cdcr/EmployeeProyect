using BE;
using BE.Abstract.Interfaces.Service;
using EmployeeApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmployeeApp.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IProfileService _employeeProfileService;
        public ProfileController(IProfileService employeeService)
        {
            _employeeProfileService = employeeService;
        }
        #region ---------Actions-------------
        public ActionResult Index()
        {
            var employeeProfileList = GetEmployeeProfiles();
            return View(employeeProfileList);
        }
        // POST: Employee
        [HttpPost]
        public IActionResult Index(string id)
        {
            try
            {
                string sentId = id ?? string.Empty;
                if (ModelState.IsValid)
                {
                    // This validation is included since textbox accepts numeric and empty values
                    Regex regex = new Regex(@"^\d+$");

                    if (string.IsNullOrWhiteSpace(sentId) || regex.Match(sentId).Success)
                    {
                        //Servicio 
                        //var employeeList = GetEmployeesFromAPI(string.IsNullOrWhiteSpace(sentId) ? 0 : int.Parse(sentId));
                        //Base de Datos
                        var employeeProfileList = GetEmployeeProfiles(string.IsNullOrWhiteSpace(sentId) ? 0 : int.Parse(sentId));
                        ViewBag.Warning = employeeProfileList.Count() + " Result(s)...";
                        return View(employeeProfileList);
                    }
                    ViewBag.Warning = "Wrong Value";
                }
                //return View(employeeFacade.GetEmptyEmployeesList());
                return View(GetEmptyEmployeeProfilesList());
            }
            catch (Exception ex)
            {
                ex.Data.Add("EmployeeController", "HttpPost Index()");
                //Log Exception from inferior layers
                return View("Error");
            }
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProfileModel employeeProfileModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Profile employeeProfile = new Profile()
                    {
                        Id = employeeProfileModel.Id,
                        Description = employeeProfileModel.Description,
                        DateCreated = employeeProfileModel.DateCreated,
                        DateUpdated = employeeProfileModel.DateUpdated,
                        Name = employeeProfileModel.Name,
                        Salary = employeeProfileModel.Salary
                    };
                    _employeeProfileService.AddEmployeeProfileDB(employeeProfile);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult Edit(int Id)
        {
            ProfileModel employeeProfile = GetProfile(Id);
            return View(employeeProfile);
        }

        [HttpPost]
        public IActionResult Edit(ProfileModel employeeProfileModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Profile employeeProfile = new Profile()
                    {
                        Id = employeeProfileModel.Id,
                        Description = employeeProfileModel.Description,
                        DateCreated = employeeProfileModel.DateCreated,
                        DateUpdated = employeeProfileModel.DateUpdated,
                        Name = employeeProfileModel.Name,
                        Salary = employeeProfileModel.Salary
                    };
                    _employeeProfileService.UpdateEmployeeProfileDB(employeeProfile);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Delete(ProfileModel employeeProfileModel)
        {
            Profile employeeProfile = new Profile()
            {
                Id = employeeProfileModel.Id,
                Description = employeeProfileModel.Description,
                DateCreated = employeeProfileModel.DateCreated,
                DateUpdated = employeeProfileModel.DateUpdated,
                Name = employeeProfileModel.Name,
                Salary = employeeProfileModel.Salary
            };
            _employeeProfileService.RemoveEmployeeProfileDB(employeeProfile);
            return RedirectToAction("Index");
        }

        #endregion

        #region --------Methods-------
        public List<ProfileModel> GetEmployeeProfiles(int id = 0)
        {
            try
            {
                var EmployeeProfileModelList = new List<ProfileModel>();
                var employeeProfiles = id == 0 ?
                         _employeeProfileService.GetEmployeeProfileList() :
                         _employeeProfileService.GetEmployeeProfileList().Where(x => x.Id == id).ToList();
                foreach (var item in employeeProfiles)
                {
                    ProfileModel employeeProfileModel = new ProfileModel()
                    {
                        Id = item.Id,
                        Description=item.Description,
                        DateCreated=item.DateCreated,
                        DateUpdated=item.DateUpdated,
                        Name = item.Name,
                        Salary=item.Salary
                    };
                    EmployeeProfileModelList.Add(employeeProfileModel);
                }
                return EmployeeProfileModelList;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public List<ProfileModel> GetEmptyEmployeeProfilesList(int id = 0)
        {
            return new List<ProfileModel>();
        }
        public ProfileModel GetProfile(int id)
        {
            try
            {
                var employeeProfile = _employeeProfileService.GetEmployeeProfile(id);
                ProfileModel employeeProfileModel = new ProfileModel()
                {
                    Id = employeeProfile.Id,
                    Description = employeeProfile.Description,
                    DateCreated = employeeProfile.DateCreated,
                    DateUpdated = employeeProfile.DateUpdated,
                    Name = employeeProfile.Name,
                    Salary = employeeProfile.Salary
                };

                return employeeProfileModel;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
