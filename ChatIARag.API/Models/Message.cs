namespace ChatIARag.API.Models;

public class Message
{
    public Guid Id { get; set; }
    public string ConversationId { get; set; }
    public string Content { get; set; }
    public string Role { get; set; }
    public DateTime CreatedAt { get; set; }
}
