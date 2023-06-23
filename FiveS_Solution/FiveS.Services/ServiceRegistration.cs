using FiveS.Services.Contracts;
using FiveS.Services.ServiceManagement;
using Microsoft.Extensions.DependencyInjection;

namespace FiveS.Services
{
    public static class ServiceRegistration
    {
        public static void ConfigureServiceManager(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
        }
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserManager>();
            //services.AddScoped<IAnswerService,AnswerManager>();
            //services.AddScoped<IAuditService,AuditService>();
            //services.AddScoped<IAuditAnswerService,AuditAnswerManager>();
            //services.AddScoped<IAuditControlAreaService,AuditControlAreaManager>();
            //services.AddScoped<IFacilityService,FacilityManager>();
            //services.AddScoped<IPhotoService,PhotoManager>();
            //services.AddScoped<IQuestionService,QuestionManager>();
            //services.AddScoped<IStepService,StepManager>();
            //services.AddScoped<ITokenService,TokenManager>();
        }
    }
}
