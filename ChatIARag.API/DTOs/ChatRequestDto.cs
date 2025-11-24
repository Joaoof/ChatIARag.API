using ChatIARag.API.Models;

namespace ChatIARag.API.DTOs;

public class ChatRequestDto
{
    public Guid ConversationId { get; set; }
    public ICollection<Message>? Messages { get; set; }
}
