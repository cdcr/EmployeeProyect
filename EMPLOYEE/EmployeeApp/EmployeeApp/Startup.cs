using BE;
using BE.Abstract.Interfaces;
using BE.Abstract.Interfaces.Repository;
using BE.Abstract.Interfaces.Service;
using Core.Factory;
using Core.Service;
using Data.DTO;
using DL;
using DL.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {            
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public int EmployeeService { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            var configuration = Configuration.GetConnectionString("EmployeeDB");
            //services.AddTransient<IBaseRepository, BaseRepository>();
            services.AddTransient<IEmployeeClientService, EmployeeClientService>();
            services.AddTransient<IEmployeeFactory, EmployeeFactory>();            
            services.AddTransient<IEmployeeClientRepository, EmployeeClientRepository>();
            services.AddTransient<IEmployee, Employee>();
            //services.AddTransient<IEmployeeDTO, EmployeeDTO>();

            //var conection = @"Server=DESKTOP-P3J47JR; Database=PROYECTO; Trusted_Connection=True; ConnectRetryCount=0";
            services.AddDbContext<EmployeeContext>(options => options.UseSqlServer(configuration));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
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
}
