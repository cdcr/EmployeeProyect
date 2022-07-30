using BE;
using BE.Abstract.Interfaces;
using BE.Abstract.Interfaces.Repository;
using DL.Repository;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace DLService.Repository
{
    public class EmployeeClientRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        IConfiguration _configuration;
        public EmployeeClientRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public List<Employee> GetEmployeeDetailedList()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeDetailed(string id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployeeList()
        {
            try
            {
                List<Employee> jsonResult;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_configuration.GetSection("EmployeeApiUrl").Value);
                //request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    jsonResult = JsonConvert.DeserializeObject<List<Employee>>(reader.ReadToEnd());
                }
                return jsonResult.Cast<Employee>().ToList();
            }
            catch (Exception ex)
            {
                // Log exception
                ex.Data.Add("EmployeeClientRepository", "GetEmployeeList()");
                throw ex;
            }
        }

        public void RemoveemployeeDetailed(string id)
        {
            throw new NotImplementedException();
        }

        public void AddEmployeeDetailed(Employee employee)
        {
            throw new NotImplementedException();
        }
    }

}
