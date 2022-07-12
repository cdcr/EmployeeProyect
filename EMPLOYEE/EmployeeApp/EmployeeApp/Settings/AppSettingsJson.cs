using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApp.Settings
{
    public class AppSettingsJson
    {
        private readonly IConfiguration _configuration;

        public AppSettingsJson(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string Host => _configuration["DATABASE_CS"];
    }
}
