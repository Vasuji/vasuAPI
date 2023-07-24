using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace VasuAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Other service registrations...
            services.AddControllers();
            services.AddSwaggerGen();

            services.AddSingleton<CsvDataService>(new CsvDataService("sample.csv"));

            // Other service registrations...
        }

    }
}

