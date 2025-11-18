using Microsoft.AspNetCore.Identity;

namespace ChatIARag.API.Models;

public class User: IdentityUser
{
    public DateTime MemberSince { get; set; }
    public ICollection<Conversation>? Conversations { get; set; }
}
