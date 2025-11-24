namespace ChatIARag.API.DTOs;

public class ChatResponseDto
{
    public Guid MessageId { get; set; }
    public string Content { get; set; }
    public string Role { get; set; }
    public DateTime Timestamp { get; set; }
}
