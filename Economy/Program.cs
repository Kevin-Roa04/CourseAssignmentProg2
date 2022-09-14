using Appcore.Interface;
using Appcore.Service;
using Autofac;
using Dominio.Interface;
using Economy.AppCore.IServices;
using Economy.AppCore.Processes.Calculate;
using Economy.AppCore.Services;
using Economy.AppCore.Services.InterestsServices;
using Economy.Domain.Entities;
using Economy.Domain.Interfaces;
using Economy.Forms;
using Economy.Infraestructure.Repository;
using Economy.Infraestructure.Repository.Interests;
using Infraestructure.Repository;
using InteresPratica;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Proto1._0;
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
            services.AddScoped<IInterestRepository<Annuity>, AnnuityRepository>();
            services.AddScoped<IInterestRepository<Serie>, SerieRepository>();
            services.AddScoped<IInterestRepository<Interest>, InterestRepository>();
            services.AddScoped<ICalculateServices<Interest>, CalculateInterest>();
            services.AddScoped<IInterestServices<Annuity>, AnnuityServices>();
            services.AddScoped<IInterestServices<Serie>, SerieServices>();
            services.AddScoped<IInterestServices<Interest>, InterestServices>();
            services.AddScoped<ICalculateServices<Annuity>, CalculateAnnuities>();
            services.AddScoped<ICalculateServices<Serie>, CalculateSerie>();

            services.AddScoped<INominalServices, NominalServices>();
            services.AddScoped<IInteresNominal, NominalRepository>();
            //simple
            services.AddScoped<ISimpleService, SimpleService>();
            services.AddScoped<IModelSimple, SimpleRepository>();
            //Compuesto
            services.AddScoped<ICompuestoService, CompuestoService>();
            services.AddScoped<IModelCompuesto, CompuestoRepository>();
            //Converter
            services.AddScoped<IConvertService, ConvertService>();
            services.AddScoped<IModelConverticion, ConvertRepository>();
            //Depreciation
            services.AddScoped<IDepreciationService, DepreciationService>();
            services.AddScoped<IModelDepreciation, DepreciationRepository>();

            services.AddScoped<IAmortizacionServices, AmortizacionServices>();
            services.AddScoped<IAmortizacion, AmortizacionRepository>();
            services.AddScoped<FormLogin>();

            using (var serviceScope = services.BuildServiceProvider())
            {
                var main = serviceScope.GetRequiredService<FormLogin>();
                Application.Run(main);
            }



        }


        //correr cualquier form especifico
        //static void Main()
        //{
        //    // To customize application configuration such as set high DPI settings or default font,
        //    // see https://aka.ms/applicationconfiguration.

        //    Application.Run(new FormCreateProject());
        //}
    }
}
