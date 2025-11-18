using ChatIARag.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatIARag.API.Config
{
    public class ConversationConfiguration: IEntityTypeConfiguration<Conversation>
    {
        public void Configure(EntityTypeBuilder<Conversation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(c => c.UserId).IsRequired().HasMaxLength(450);
            builder.Property(c => c.CreatedAt).IsRequired();

            builder.HasOne<User>() // Um User
               .WithMany(u => u.Conversations) // Tem Muitas Conversations
               .HasForeignKey(c => c.UserId) // A chave estrangeira é UserId
               .IsRequired()
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
