using Domain.Abstractions;
using Infrastructure.Context;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CrossCutting.DependeciesApp
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var Conn = configuration.GetConnectionString("Sqlite");
            services.AddDbContext <SystemContext>(opt=>opt.UseSqlite(Conn));
            services.AddScoped<IContactoRepository, ContactoRepository>();
            return services;

        }

    }
}
