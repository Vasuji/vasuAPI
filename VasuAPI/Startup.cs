using System.Diagnostics;
using System.IO;
using VasuAPI.Services;


namespace VasuAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddControllers();

            // Other service registrations...
            services.AddSingleton((Func<IServiceProvider, IJsonDataService>)(sp =>
            {
                var env = sp.GetRequiredService<IWebHostEnvironment>();
                var path = System.IO.Path.Combine(env.ContentRootPath, "./Data/sample.json");
                return new JsonDataService(path);
            }));

            // Other service registrations...
            services.AddSingleton(sp => new CsvDataService("./Data/sample.csv"));


            // Other service registrations...
            services.AddTransient<IMatrixGeneratorService, MatrixGeneratorService>();


        }
    }

}