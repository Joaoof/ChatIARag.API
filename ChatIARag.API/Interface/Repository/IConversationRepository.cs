using ChatIARag.API.DTOs.Response;
using ChatIARag.API.Models;

namespace ChatIARag.API.Interface.Repository;

public interface IConversationRepository
{
    Task<List<Conversation>> GetAll();
    Task<List<Conversation>> GetAllNoTracking();
    Task<Conversation> GetByIdAsync(Guid id);
    Task<Conversation> DeleteAsync(Conversation entity);
    Task<List<Conversation>> GetAllByUserIdAsync(Guid userId);
}
