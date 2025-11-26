using ChatIARag.API.Data.Context;
using ChatIARag.API.Interface.Repository;
using ChatIARag.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatIARag.API.Repositories;

public class MessageRepository : IMessageRepository
{
    private readonly ChatIARagDbContext _context;
    private readonly IUnitOfWork _unitOfWork;

    public MessageRepository(ChatIARagDbContext context, IUnitOfWork unitOfWork)
    {
        _context = context;
        _unitOfWork = unitOfWork;
    }

    public async Task CreateAsync(Message message)
    {
         await _context.Message.AddAsync(message);
    }

    public async Task DeleteAsync(Guid messageId, Message message)
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
        var msg = await _context.Message.FirstOrDefaultAsync(m => m.Id == id);

        if(msg != null)
        {
            return msg; 
        }

        return null;
    }

    public async Task<Message?> UpdateAsync(Guid messageId, string content)
    {
        var existingMessage = await _context.Message.FindAsync(messageId);

        if(existingMessage is null)
        {
            return null;
        }
        existingMessage.Content = content;

       _context.Message.Update(existingMessage);

        return existingMessage;
    }
}
