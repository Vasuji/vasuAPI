using System.Diagnostics;
using System.IO;


namespace VasuAPI.Services
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton((Func<IServiceProvider, IJsonDataService>)(sp =>
            {
                var env = sp.GetRequiredService<IWebHostEnvironment>();
                var path = System.IO.Path.Combine(env.ContentRootPath, "sample.json");
                return new JsonDataService(path);
            }));

            // Other service registrations...
            _ = services.AddSingleton(sp => new CsvDataService("sample.csv"));

            services.AddTransient<IMatrixGeneratorService, MatrixGeneratorService>();


        }
    }

}