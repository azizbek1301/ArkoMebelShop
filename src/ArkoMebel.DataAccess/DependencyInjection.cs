﻿using ArkoMebel.Infrastructure.Peristance;
using ArkoMebel.Service.Abstraction.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ArkoMebel.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection service,IConfiguration configuration)
        {
            service.AddDbContext<IApplicationDbContext, ApplicationDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("Default"));
            });
            return service;
        }
    }
}
