using ChatIARag.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatIARag.API.Data;

public class ChatIARagDbContext: DbContext
{
    public ChatIARagDbContext(DbContextOptions options): base(options)
    {
        
    }

    public DbSet<Conversation> ConversationSet { get; set; }
    public DbSet<Message> MessageSet { get; set; }
    public DbSet<Document> DocumentSet { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Conversation>().Property(c => c.Messages).IsRequired();
    }
}
