using ChatIARag.API.Data.Context;
using ChatIARag.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ChatIARag.API.Data.Repository;

public class Repository<T>
{
    protected ChatIARagDbContext _context { get; private set; }
    private DbSet<Conversation> DbSet => _context.Set<Conversation>();
    public Repository(ChatIARagDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Conversation>> GetAllAsync(Expression<Func<Conversation, bool>> predicate)
    {
        return predicate != null ? await DbSet.Where(predicate).ToListAsync() : await DbSet.ToListAsync();
    }
}
