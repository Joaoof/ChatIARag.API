using ChatIARag.API.DTOs.Response;
using ChatIARag.API.Models;

namespace ChatIARag.API.Interface.Repository;

public interface IConversationRepository
{
    Task<List<ConversationViewModel>> GetAll();
    Task<List<ConversationViewModel>> GetAllNoTracking();
    Task<ConversationViewModel> GetByIdAsync(Guid id);
    Task<ConversationViewModel> DeleteAsync(ConversationViewModel entity);
    Task<List<Conversation>> GetAllByUserIdAsync(Guid userId);
}
