using ChatIARag.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatIARag.API.Config;

public class DocumentConfiguration: IEntityTypeConfiguration<Document>
{
    public void Configure(EntityTypeBuilder<Document> builder)
    {
        builder.HasKey(d => d.Id);

        builder.Property(d => d.FileName).IsRequired().HasMaxLength(100);
        builder.Property(d => d.Content).IsRequired().HasMaxLength(500);
        builder.Property(d => d.Embeddings).IsRequired();

        builder.HasOne(d => d.Conversation).WithMany(d => d.Documents).HasForeignKey(d => d.ConversationId).OnDelete(DeleteBehavior.ClientCascade);

    }
}
