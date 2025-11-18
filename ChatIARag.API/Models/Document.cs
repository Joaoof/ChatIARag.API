using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatIARag.API.Models;

public class Document
{
    public Guid Id { get; set; }
    [Key]
    [ForeignKey("Conversation")]
    public string ConversationId { get; set; }
    public Conversation Conversation { get; set; }
    public string FileName { get; set; }
    public string Content { get; set; }
    public float[] Embeddings { get; set; }
    public DateTime UploadedAt { get; set; }
}
