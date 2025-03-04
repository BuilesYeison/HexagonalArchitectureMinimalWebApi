using Application.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            // inject usecases
            services.AddScoped<SendEmailUseCase>();

            return services;
        } 
    }
}
