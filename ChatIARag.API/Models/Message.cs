using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatIARag.API.Models;

public class Message
{
    public Guid Id { get; set; }
    [Key]
    [ForeignKey("Conversation")]
    public Guid ConversationId { get; set; }
    public Conversation Conversation { get; set; }
    public string Content { get; set; }
    public string Role { get; set; }
    public DateTime TimesTamp { get; set; }
    public bool IsFromWhatsApp { get; set; }
    public string Metadata { get; set; }
}
