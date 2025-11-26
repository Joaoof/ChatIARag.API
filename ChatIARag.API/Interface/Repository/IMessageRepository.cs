using ChatIARag.API.Models;

namespace ChatIARag.API.Interface.Repository;

public interface IMessageRepository
{
    Task<List<Message>> GetAllAsync();
    Task<List<Message>> GetByConversationIdAsync(Guid conversationId);
    Task<Message> GetByIdAsync(Guid id);
    Task CreateAsync(Message message);
    Task<Message?> UpdateAsync(Guid messageId, string content);
    Task DeleteAsync(Guid messageId, Message message);
}
