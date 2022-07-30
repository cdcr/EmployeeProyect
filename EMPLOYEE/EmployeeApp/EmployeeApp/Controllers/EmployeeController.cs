
//using EmployeeApp.Facade;
using BE;
using BE.Abstract.Interfaces.Service;
using DL;
using EmployeeApp.Models;
using EmployeeApp.Models.EmployeeTransforms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IProfileService _employeeProfileService;
        private readonly IMemoryCache _memoryCache;
        private readonly IConfiguration _configuration;

        //readonly IEmployeeClientService employeeClientService;
        public EmployeeController(IEmployeeService employeeService, IProfileService
            profileService, IMemoryCache memoryCache, IConfiguration configuration)
        {
            _employeeService = employeeService;
            _employeeProfileService = profileService;
            _memoryCache = memoryCache;
            _configuration = configuration;
        }
        #region ---------Actions-------------
        // GET: Employee
        public ActionResult Index()
        {
            var employeeList = new List<EmployeeModel>();
            if (!Convert.ToBoolean(_configuration.GetSection("DataModificated").Value))
            {
                employeeList = _memoryCache.GetOrCreate("GetEmpployeesw",
                                cacheEntry =>
                                {
                                    return GetEmployees();
                                });
            }
            else
            {
                employeeList = GetEmployees();
            }
            return View(employeeList);
        }
        // POST: Employee
        [HttpPost]
        public IActionResult Index(string id="0")
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
                        var employeeList = new List<EmployeeModel>();
                        
                        if (!Convert.ToBoolean(_configuration.GetSection("DataModificated").Value) & id!="0")
                        {
                            employeeList = _memoryCache.GetOrCreate("GetEmpployees",
                            cacheEntry =>
                            {
                                return GetEmployees(string.IsNullOrWhiteSpace(sentId) ? "0" : sentId.ToString());
                            });
                        }
                        else
                        {
                            employeeList = GetEmployees(string.IsNullOrWhiteSpace(sentId) ? "0" : sentId);
                        }
                        ViewBag.Warning = employeeList.Count() + " Result(s)...";
                        return View(employeeList);
                    }
                    ViewBag.Warning = "Wrong Value";
                }
                var EmployeList = GetEmptyEmployeesList();
                //var EmployeList= _memoryCache.GetOrCreate("GetEmpployeeList",
                //            cacheEntry => {
                //                return GetEmptyEmployeesList();
                //            });
                return View(EmployeList);
            }
            catch (Exception ex)
            {
                ex.Data.Add("EmployeeController", "HttpPost Index()");
                //Log Exception from inferior layers
                return View("Error");
            }
        }

        public ActionResult CreateEmployee()
        {
            EmployeeCreateModel employee = new EmployeeCreateModel();
            employee.Profiles = _employeeProfileService.GetEmployeeProfileList();
            return View(employee);
        }

        [HttpPost]
        public IActionResult CreateEmployee(EmployeeCreateModel employeeCreateModel)
        {
            Profile profile = null;
            try
            {
                profile = _employeeProfileService.GetEmployeeProfile(employeeCreateModel.ProfileId);
                if (ModelState.IsValid)
                {
                    var employee = new Employee()
                    {
                        //ID = employeeCreateModel.ID,
                        ContractTypeName = employeeCreateModel.ContractTypeName,
                        Name = employeeCreateModel.Name,
                        ProfileId = employeeCreateModel.ProfileId,
                        ProfileName = profile.Name,
                        RoleDescription = profile.Description,
                        MonthlySalary = employeeCreateModel.HourlySalary,
                        HourlySalary = employeeCreateModel.HourlySalary
                    };
                    _employeeService.AddEmployeeDB(employee);
                    _configuration.GetSection("DataModificated").Value = "true";
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

        public ActionResult Edit(string Id)
        {
            EmployeeCreateModel employee = GetEmployee(Id);
            employee.Profiles = _employeeProfileService.GetEmployeeProfileList();
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(EmployeeCreateModel employeeCreateModel)
        {
            Profile profile = null;
            Transforms Transform = new Transforms();

            try
            {
                profile = _employeeProfileService.GetEmployeeProfile(employeeCreateModel.ProfileId);
                if (ModelState.IsValid)
                {
                    //Transform = new Transforms(employeeCreateModel);
                    //employee = Transform.EmployeeCreateModelToEmployee(employeeCreateModel,profile);
                    var employee = new Employee()
                    {
                        Id = employeeCreateModel.Id,
                        ContractTypeName = employeeCreateModel.ContractTypeName,
                        Name = employeeCreateModel.Name,
                        ProfileId = employeeCreateModel.ProfileId,
                        ProfileName = profile.Name,
                        RoleDescription = employeeCreateModel.Description,
                        MonthlySalary = employeeCreateModel.MonthlySalary,
                        HourlySalary = employeeCreateModel.HourlySalary
                    };
                    _employeeService.UpdateEmployeeDB(employee);
                    _configuration.GetSection("DataModificated").Value = "true";
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
        public IActionResult Delete(EmployeeCreateModel employeeCreateModel)
        {
            //Transforms transform = new Transforms();
            //Profile profile = new Profile();
            //var employee = transform.EmployeeCreateModelToEmployee(employeeCreateModel,profile);
            var employee = new Employee()
            {
                Id = employeeCreateModel.Id,
                ContractTypeName = employeeCreateModel.ContractTypeName,
                Name = employeeCreateModel.Name,
                ProfileId = employeeCreateModel.Id,
                ProfileName = employeeCreateModel.Name,
                RoleDescription = employeeCreateModel.Description,
                MonthlySalary = employeeCreateModel.MonthlySalary,
                HourlySalary = employeeCreateModel.HourlySalary
            };
            //_employeeService.RemoveemployeeDB(employee);
            _employeeService.RemoveemployeeDetailedDB(employee);
            _configuration.GetSection("DataModificated").Value = "true";
            return RedirectToAction("Index");
        }
        #endregion

        #region --------Methods-------
        public List<EmployeeModel> GetEmployees(string id = "0")
        {
            try
            {
                //var lista = _unitOfWork.EmployeeRepository.GetAll().Cast<IEmployee>().ToList();
                var EmployeeModelList = new List<EmployeeModel>();
                //var employees = _employeeService.GetEmployeeListDB();
                var employees = id == "0" ?
                         _employeeService.GetEmployeeDetailedListDB() :
                         _employeeService.GetEmployeeDetailedListDB().Where(x => x.Id == id).ToList();
                        //_employeeService.GetEmployeeList() :
                        //_employeeService.GetEmployeeList().Where(x => x.Id == id).ToList();

                foreach (var item in employees)
                {
                    double anualSalary = _employeeService.GetAnualSalary(item);
                    EmployeeModel employeeModel = new EmployeeModel(item, anualSalary);
                    EmployeeModelList.Add(employeeModel);
                }
                _configuration.GetSection("DataModificated").Value = "false";
                return EmployeeModelList;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public List<EmployeeModel> GetEmptyEmployeesList(string id = "0")
        {
            return new List<EmployeeModel>();
        }
        public EmployeeCreateModel GetEmployee(string id)
        {
            //Transforms Transform = null;
            try
            {
                //var employee = _employeeService.GetEmployee(id);
                var employee = _employeeService.GetEmployeeDetailedDB(id);
                //Profile profile = new Profile();
                //Transform = new Transforms();
                //var employeeCreateModel = Transform.EmployeeToEmployeeCreateModel(employee,profile);
                EmployeeCreateModel employeeCreateModel = new EmployeeCreateModel
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    ContractTypeName = employee.ContractTypeName,
                    ProfileId = employee.Profile.Id,
                    ProfileName = employee.Profile.Name,
                    Description = employee.RoleDescription,
                    HourlySalary = employee.HourlySalary,
                    MonthlySalary = employee.MonthlySalary
                };
                return employeeCreateModel;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        #endregion


    }
}


