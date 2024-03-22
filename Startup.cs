using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Laba45.Models.Entity;
using Laba45.Models;
using Laba45.Managers.Hospitals;
using Laba45.Managers.Doctors;
using Laba45.Managers.Patients;
using Laba45.Managers.Sick_Lists;
using Laba45.Managers.Receptions;
using Laba45.Managers.Medical_Records;
using Laba45.Managers.Nurses;

namespace Laba45
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddTransient<IHospitalManager, HospitalManager>();
            services.AddTransient<IDoctorManager, DoctorManager>();
            services.AddTransient<IPatientManager, PatientManager>();
            services.AddTransient<ISickListManager, SickListManager>();
            services.AddTransient<IReceptionManager, ReceptionManager>();
            services.AddTransient<IMedicalRecordManager, MedicalRecordManager>();
            services.AddTransient<INurseManager, NurseManager>();
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DataContext>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "default",
                  template: "{controller=Hospital}/{action=MainPage}/{id?}");
            });
        }
    }
}
