namespace ChatIARag.API.Models;

public class User
{
    public Guid Id {  get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime MemberSince { get; set; } = DateTime.UtcNow;
    public ICollection<Conversation>? Conversations { get; set; }
}
