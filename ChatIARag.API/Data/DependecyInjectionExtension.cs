using ChatIARag.API.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ChatIARag.API.Data;

public static class DependecyInjectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        AddDbContext(services, configuration);
    }

    private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Connection");

        services.AddDbContext<ChatIARagDbContext>(config => config.UseNpgsql(connectionString));
    }
}
