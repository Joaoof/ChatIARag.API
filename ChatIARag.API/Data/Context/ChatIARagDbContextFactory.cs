using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ChatIARag.API.Data.Context;

public class ChatIARagDbContextFactory : IDesignTimeDbContextFactory<ChatIARagDbContext>
{
    public ChatIARagDbContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Development.json").Build();

        var builder = new DbContextOptionsBuilder<ChatIARagDbContext>();

        var connectionString = configuration.GetConnectionString("Connection");

        builder.UseNpgsql(connectionString);

        return new ChatIARagDbContext(builder.Options);
    }
}
