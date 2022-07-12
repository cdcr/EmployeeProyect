
//using EmployeeApp.Facade;
using BE.Abstract.Interfaces.Service;
using EmployeeApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        readonly IEmployeeClientService employeeClientService;
        public EmployeeController(IEmployeeClientService _employeeClientService)
        {
            employeeClientService = _employeeClientService;
        }

        // GET: Employee
        public ActionResult Index()
        {
            
            var employeeList = GetEmployeesFromAPI();
            //var employeeList = GetEmployeesFromDB();
            return View(employeeList);
        }

        // POST: Employee
        [HttpPost]
        public IActionResult Index(string id)
        {
            try
            {
                string sentId = id ?? string.Empty;
                //EmployeeFacade employeeFacade = new EmployeeFacade(employeeClientService);
                if (ModelState.IsValid)
                {
                    // This validation is included since textbox accepts numeric and empty values
                    Regex regex = new Regex(@"^\d+$");

                    if (string.IsNullOrWhiteSpace(sentId) || regex.Match(sentId).Success)
                    {
                       //Servicio 
                        var employeeList = GetEmployeesFromAPI(string.IsNullOrWhiteSpace(sentId) ? 0 : int.Parse(sentId));
                        //Base de Datos
                        //var employeeList = GetEmployeesFromDB(string.IsNullOrWhiteSpace(sentId) ? 0 : int.Parse(sentId));
                        ViewBag.Warning = employeeList.Count() + " Result(s)...";
                        return View(employeeList);
                    }
                    ViewBag.Warning = "Wrong Value";
                }
                //return View(employeeFacade.GetEmptyEmployeesList());
                return View(GetEmptyEmployeesList());
            }
            catch (Exception ex) 
            {                
                ex.Data.Add("EmployeeController", "HttpPost Index()");
                //Log Exception from inferior layers
                return View("Error");
            }
        }

        [HttpPost]
        public List<EmployeeModel> GetEmployeesFromAPI(int id = 0)
        {
            try
            {
                var EmployeeModelList = new List<EmployeeModel>();
                var EmployeeList = id == 0 ?
                        employeeClientService.GetEmployeeList() :
                        employeeClientService.GetEmployeeList().Where(x => x.ID == id).ToList();
                foreach (var employeeListItem in EmployeeList)
                {
                    double anualSalary = employeeClientService.GetAnualSalary(employeeListItem);
                    EmployeeModel employeeModel = new EmployeeModel(employeeListItem, anualSalary);
                    EmployeeModelList.Add(employeeModel);
                }
                return EmployeeModelList;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public List<EmployeeModel> GetEmployeesFromDB(int id = 0)
        {
            try
            {
                var EmployeeModelList = new List<EmployeeModel>();
                var EmployeeList = id == 0 ?
                        employeeClientService.GetEmployeeListDB() :
                        employeeClientService.GetEmployeeListDB().Where(x => x.ID == id).ToList();
                foreach (var employeeListItem in EmployeeList)
                {
                    double anualSalary = employeeClientService.GetAnualSalary(employeeListItem);
                    EmployeeModel employeeModel = new EmployeeModel(employeeListItem, anualSalary);
                    EmployeeModelList.Add(employeeModel);
                }
                return EmployeeModelList;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public List<EmployeeModel> GetEmptyEmployeesList(int id = 0)
        {
            return new List<EmployeeModel>();
        }


    }
}