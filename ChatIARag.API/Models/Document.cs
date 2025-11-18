namespace ChatIARag.API.Models;

public class Document
{
    public Guid Id { get; set; }
    public string ConversationId { get; set; }
    public string FileName { get; set; }
    public string Content { get; set; }
    public float[] Embeddings { get; set; }
    public DateTime UploadedAt { get; set; }
}
