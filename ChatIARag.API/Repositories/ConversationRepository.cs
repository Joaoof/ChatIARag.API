using ChatIARag.API.Data.Context;
using ChatIARag.API.Interface.Repository;
using ChatIARag.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatIARag.API.Repositories;

public class ConversationRepository : IConversationRepository
{
    private readonly ChatIARagDbContext _context;
    public ConversationRepository(ChatIARagDbContext context)
    {
        _context = context;
    }

    public Task<Conversation> DeleteAsync(Conversation entity)
    {
        _context.Conversation.Remove(entity);
        return Task.FromResult(entity);
    }

    public async Task<List<Conversation>> GetAll()
    {
        return await _context.Conversation.ToListAsync();
    }

    public async Task<List<Conversation>> GetAllByUserIdAsync(Guid userId)
    {
        var item = await _context.Conversation.Where(c => c.UserId == userId).ToListAsync();

        return item;

    }

    public async Task<IEnumerable<Conversation>> GetAllNoTracking()
    {
        var data = await _context.Conversation.AsNoTracking().ToListAsync();

        return data.AsEnumerable();
    }

    public async Task<Conversation> GetByIdAsync(Guid id)
    {
        return await _context.Conversation.FirstOrDefaultAsync(c => c.Id == id);
    }
}
