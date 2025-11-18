using ChatIARag.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatIARag.API.Config
{
    public class MessageConfiguration: IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Content).IsRequired().HasMaxLength(255);
            builder.Property(m => m.Role).IsRequired().HasMaxLength(20);

            builder.HasOne(a => a.Conversation).WithMany(a => a.Messages).HasForeignKey(a => a.ConversationId).OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
