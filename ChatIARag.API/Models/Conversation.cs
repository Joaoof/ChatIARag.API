namespace ChatIARag.API.Models;

public class Conversation
{
    public Guid Id { get; set; }
    public required string UserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public ICollection<Message>? Messages { get; set; }
    public ICollection<Document>? Documents { get; set; }
}
