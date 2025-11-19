using ChatIARag.API.Models;

namespace ChatIARag.API.DTOs.Response;

public class ConversationViewModel
{
    public DateTime CreatedAt { get; set; }
    public ICollection<Message>? Messages { get; set; }
    public ICollection<Document>? Documents { get; set; }
}
