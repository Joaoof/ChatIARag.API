using ChatIARag.API.DTOs.Response;

namespace ChatIARag.API.Interface.Repository;

public interface IConversationRepository
{
    Task<List<ConversationViewModel>> GetAll();
    Task<List<ConversationViewModel>> GetAllNoTracking();
    Task<ConversationViewModel> GetByIdAsync(int id);
    Task<ConversationViewModel> DeleteAsync(ConversationViewModel entity);
}
