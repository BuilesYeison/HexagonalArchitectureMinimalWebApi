using Application.Ports.Repositories;
using Application.Ports.Services;
using Infrastructure.Adapters.Repositories;
using Infrastructure.Adapters.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IEmailService, SendGridService>();
            services.AddScoped<IEmailMessagesRepository, EmailMessagesRepository>();

            return services;
        }
    }
}
