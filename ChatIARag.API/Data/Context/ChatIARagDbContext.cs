using ChatIARag.API.Config;
using ChatIARag.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatIARag.API.Data.Context;

public class ChatIARagDbContext: DbContext
{
    public ChatIARagDbContext(DbContextOptions options): base(options)
    {
        
    }

    public DbSet<Conversation> Conversation { get; set; }    
    public DbSet<Message> Message { get; set; }
    public DbSet<Document> Document { get; set; }
    public DbSet<User> User { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ConversationConfiguration());
        modelBuilder.ApplyConfiguration(new DocumentConfiguration());
        modelBuilder.ApplyConfiguration(new MessageConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
    }
}
