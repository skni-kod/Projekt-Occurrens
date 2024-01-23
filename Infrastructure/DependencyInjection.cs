using System.Reflection.Metadata;
using Core.Account.Repositories;
using Infrastructure.Account.Repositories;
using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<OccurrensDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("WebApiDatabase"),
                r => r.MigrationsAssembly(typeof(AssemblyReference).Assembly.ToString())));
        
        
        
        services.AddScoped<IAccountRepository, AccountRepository>();
        
        return services;
    }
}