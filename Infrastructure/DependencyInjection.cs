using System.Reflection.Metadata;
using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection service, IConfiguration configuration)
    {
        service.AddDbContext<OccurrensDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("WebApiDatabase"),
                r => r.MigrationsAssembly(typeof(AssemblyReference).Assembly.ToString())));
        
        return service;
    }
}