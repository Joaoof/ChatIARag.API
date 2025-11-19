using ChatIARag.API.Data.Context;
using ChatIARag.API.DTOs.Response;
using ChatIARag.API.Interface.Repository;

namespace ChatIARag.API.Data.Repository;

public class ConversationRepository: IConversationRepository
{
    private readonly ChatIARagDbContext _context;

    public ConversationRepository(ChatIARagDbContext context)
    {
        _context = context;
    }

    public Task<ConversationViewModel> DeleteAsync(ConversationViewModel entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<ConversationViewModel>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<List<ConversationViewModel>> GetAllNoTracking()
    {
        throw new NotImplementedException();
    }

    Task<ConversationViewModel> IConversationRepository.GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}
