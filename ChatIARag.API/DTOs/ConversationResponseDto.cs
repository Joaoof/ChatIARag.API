namespace ChatIARag.API.DTOs;

public class ConversationResponseDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public bool Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
