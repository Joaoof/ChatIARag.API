using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatIARag.API.Models;

public class Document
{
    public Guid Id { get; set; }
    [Key]
    [ForeignKey("Conversation")]
    public Guid ConversationId { get; set; }
    public Conversation Conversation { get; set; }
    public string FileName { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string VectorId { get; set; }
    public string FileType { get; set; }
    public long FileSize { get; set; }
    public int ChunkCount { get; set; }
    public float[] Embeddings { get; set; }
    public DateTime UploadedAt { get; set; }
}
