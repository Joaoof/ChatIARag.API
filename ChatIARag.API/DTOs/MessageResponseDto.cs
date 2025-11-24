namespace ChatIARag.API.DTOs;

public class MessageResponseDto
{
    public Guid Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; }
    public bool IsFromWhatsApp { get; set; }
}
