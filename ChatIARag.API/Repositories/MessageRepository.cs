using ChatIARag.API.Data.Context;
using ChatIARag.API.Interface.Repository;
using ChatIARag.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatIARag.API.Repositories;

public class MessageRepository : IMessageRepository
{
    private readonly ChatIARagDbContext _context;

    public MessageRepository(ChatIARagDbContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(Message message)
    {
         await _context.Message.AddAsync(message);
    }

    public async Task DeleteAsync(Guid messageId)
    {
       var msg = await _context.Message.FindAsync(messageId);

        if(msg != null)
        {
            _context.Message.Remove(msg);
        }
    }

    public async Task<List<Message>> GetAllAsync()
    {
        return await _context.Message.ToListAsync();
    }

    public Task<List<Message>> GetByConversationIdAsync(Guid conversationId)
    {
        return _context.Message.Where(m => m.ConversationId == conversationId)
            .ToListAsync();
    }

    public async Task<Message?> GetByIdAsync(Guid id)
    {
        return await _context.Message.FirstOrDefaultAsync(m => m.Id == id);
    }

    public async Task<Message?> UpdateAsync(Guid messageId, string content)
    {
        var message = await _context.Message.FindAsync(messageId);

        if (message is null) return null;

        message.Content = content;
        return message;
    }
}
