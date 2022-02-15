using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamManager.Repository;
using ExamManager.Domain.Identity;
using ExamManager.Repository.Implementation;
using ExamManager.Repository.Interface;
using ExamManager.Service;
using ExamManager.Service.Interface;
using ExamManager.Service.Implementation;
using ExamManager.Domain.DomainModel;
using System.IO;
using ExcelDataReader;

namespace ExamManager.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }


        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IPredmetRepository), typeof(PredmetRepository));
            services.AddScoped(typeof(ISproveduvacRepository), typeof(SproveduvacRepository));
            services.AddScoped(typeof(IStudentRepository), typeof(StudentRepository));
            services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
            services.AddScoped(typeof(IStudiskiCiklusRepository), typeof(StudiskiCiklusRepository));
            services.AddScoped(typeof(IStudiskaProgramaRepository), typeof(StudiskaProgramaRepository));
            services.AddScoped(typeof(IStudentPolagaPredmetRepository), typeof(StudentPolagaPredmetRepository));
            services.AddScoped(typeof(IIspitRepository), typeof(IspitRepository));


            services.AddTransient<IPredmetService, PredmetService>();
            services.AddTransient<ISproveduvacService, SproveduvacService>();
            services.AddTransient<IStudentService, StudentService>();
            services.AddTransient<IStudiskiCiklusService, StudiskiCiklusService>();
            services.AddTransient<IProstorijaService, ProstorijaService>();
            services.AddTransient<IIspitService, IspitService>();
            services.AddTransient<IStudentPolagaPredmetService, StudentPolagaPredmetService>();
            services.AddTransient<ITerminService, TerminService>();

            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });
        }
    }
}
