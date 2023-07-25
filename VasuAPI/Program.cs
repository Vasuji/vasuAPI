using VasuAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddTransient<IRandomNumberService, RandomNumberService>();
builder.Services.AddTransient<IMatrixGeneratorService, MatrixGeneratorService>();
builder.Services.AddSingleton(sp => new CsvDataService("./Data/sample.csv"));

builder.Services.AddSingleton((Func<IServiceProvider, IJsonDataService>)(sp =>
{
    var env = sp.GetRequiredService<IWebHostEnvironment>();
    var path = System.IO.Path.Combine(env.ContentRootPath, "./Data/sample.json");
    return new JsonDataService(path);
}));


builder.Services.AddSingleton<HttpClient>();
builder.Services.AddTransient<IConductorService, ConductorService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

