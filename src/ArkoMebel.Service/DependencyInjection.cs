using ArkoMebel.Service.Abstraction.File;
using ArkoMebel.Service.Service.Files;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ArkoMebel.Service
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient<IFileService, FileService>();
            return services;
        }
    }
}
