using FiveS.Repositories.EFCore.Context;
using FiveS.Repositories.Repositories.Contracts;
using FiveS.Repositories.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FiveS.Repositories.RepositoryManagement;

namespace FiveS.Repositories
{
    public static class ServiceRegistration
    {
        public static void ConfigureEFCoreConnectionString(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(options => options
            .UseSqlServer(configuration.GetConnectionString("appConnectionStrings")));

        }
        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            //services.AddScoped<IAnswerService,AnswerManager>();
            //services.AddScoped<IAuditService,AuditService>();
            //services.AddScoped<IAuditAnswerService,AuditAnswerManager>();
            //services.AddScoped<IAuditControlAreaService,AuditControlAreaManager>();
            //services.AddScoped<IFacilityService,FacilityManager>();
            //services.AddScoped<IPhotoService,PhotoManager>();
            //services.AddScoped<IQuestionService,QuestionManager>();
            //services.AddScoped<IStepService,StepManager>();
            //services.AddScoped<ITokenService,TokenManager>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
