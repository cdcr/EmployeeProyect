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

namespace DL.Repository
{
    public class EmployeeClientRepository :BaseRepository<EmployeeDTO>,IEmployeeClientRepository
    {
        IConfiguration _configuration;
        public EmployeeClientRepository(IConfiguration configuration):base(configuration)
        {
            _configuration = configuration;
        }

        public List<IEmployeeDTO> GetEmployeeList()
        {
            try
            {
                List<EmployeeDTO> jsonResult;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_configuration.GetSection("EmployeeApiUrl").Value);
                //request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    jsonResult = JsonConvert.DeserializeObject<List<EmployeeDTO>>(reader.ReadToEnd());
                }
                return jsonResult.Cast<IEmployeeDTO>().ToList();
            }
            catch (Exception ex)
            {
                // Log exception
                ex.Data.Add("EmployeeClientRepository", "GetEmployeeList()");
                throw ex;
            }
        }
    }
}
