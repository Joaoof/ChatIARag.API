using ChatIARag.API.Models;

namespace ChatIARag.API.Services;

public interface IConversationService
{
    public Conversation GetAllAsync();

}
