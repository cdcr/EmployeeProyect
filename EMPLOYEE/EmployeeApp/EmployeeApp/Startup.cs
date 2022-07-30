using BE;
using BE.Abstract.Interfaces;
using BE.Abstract.Interfaces.Repository;
using BE.Abstract.Interfaces.Service;
using BL.Service;
using DL;
using DL.Repository;
using DLMongo;
using DLMongo.Repository;
using DLService.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace EmployeeApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            SystemInfo systemInfo = new SystemInfo();
            systemInfo.FillSettings();
            services.AddSingleton<ISystemInfo>(systemInfo);
            if (systemInfo.Persistence == "SQL")
            {
                var optionsBuilder = new DbContextOptionsBuilder<EmployeeContext>();
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SQL"));
                services.AddSingleton(optionsBuilder.Options);
                services.AddMemoryCache();
                services.AddDbContext<EmployeeContext>();
                services.AddTransient<IUnitOfWork, UnitOfWork>();
                services.AddTransient<IEmployeeRepository, EmployeeRepository>();
                services.AddTransient<IEmployeeRepository, EmployeeClientRepository>();
                services.AddTransient<IProfileRepository, ProfileRepository>();
                services.AddTransient<IEmployeeService, EmployeeService>();
                services.AddTransient<IProfileService, ProfileService>();
            }
            else if (systemInfo.Persistence == "Mongo")
            {
                services.AddTransient<IMongoDbRepository, MongoDbRepository>();
                services.AddTransient<IUnitOfWork, UnitOfWorkMongo>();
                services.AddMemoryCache();
                services.AddTransient<IEmployeeRepository, EmployeeMongoRepository>();
                //services.AddTransient<IEmployeeRepository, EmployeeClientRepository>();
                services.AddTransient<IProfileRepository, ProfileMongoRepository>();
                services.AddTransient<IEmployeeService, EmployeeMongoService>();
                services.AddTransient<IProfileService, ProfileMongoService>();

            }
            


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //else
            //{
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
            //}

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Employee}/{action=Index}");
            });
        }
    }
    internal class SystemInfo : ISystemInfo
    {
        public string ConnectionString { get; set; }
        public string Persistence { get; set; }
        public string DataBase { get; set; }

        IConfigurationRoot root;
        SystemInfo settings;
        private static void GetSettings(out IConfigurationRoot root, out SystemInfo settings)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));
            root = builder.Build();
            settings = root.GetSection("AppSettings").Get<SystemInfo>();
        }
        public void FillSettings()
        {
            GetSettings(out root, out settings);
            ConnectionString = root.GetConnectionString(settings.Persistence);
            DataBase = settings.DataBase;
            Persistence = settings.Persistence;
        }
    }
}
