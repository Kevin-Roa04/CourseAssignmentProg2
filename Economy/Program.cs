using Economy.AppCore.IServices;
using Economy.AppCore.Services;
using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using Economy.Forms;
using Economy.Infraestructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economy
{
    static class Program
    {
        public static IConfiguration Configuration;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Configuration = new ConfigurationBuilder().AddJsonFile("AppSettings.json").
               AddEnvironmentVariables().Build();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            

  

            services.AddDbContext<EconomyContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Default"));
            });
            services.AddScoped<IEconomyDbContext, EconomyContext>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IUsersServices, UsersServices>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IProjectServices, ProjectServices>();
            services.AddScoped<FormLogin>();

            using (var serviceScope = services.BuildServiceProvider())
            {
                var main = serviceScope.GetRequiredService<FormLogin>();
                Application.Run(main);
            }
        }
    }
}
