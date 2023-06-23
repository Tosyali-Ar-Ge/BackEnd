using FiveS.Repositories;
using FiveS.Services;
using FiveS.WebApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Manuel-Configuration
//  ConnectionString
builder.Services.ConfigureEFCoreConnectionString(builder.Configuration);
// RepositoryManager
builder.Services.ConfigureRepositoryManager();
// Repositories
builder.Services.ConfigureRepositories();
// ServiceManager
builder.Services.ConfigureServiceManager();
// Services
builder.Services.ConfigureServices();
// Cors
builder.Services.ConfigureCors();
// AutoMapper
builder.Services.AddAutoMapper(typeof(Program));
#endregion

// Json Serialize -class propertylerini küçük harf yapma hatasý-
builder.Services.AddControllersWithViews().
    AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
        options.JsonSerializerOptions.PropertyNamingPolicy = null;
    }
);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");
app.UseAuthorization();
app.MapControllers();
app.Run();
