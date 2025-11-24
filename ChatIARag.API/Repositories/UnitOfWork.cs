using ChatIARag.API.Data.Context;

namespace ChatIARag.API.Repositories;

public sealed class UnitOfWork
{
    private readonly ChatIARagDbContext _context;

    public UnitOfWork(ChatIARagDbContext context)
    {
          _context = context;
    }

    public void Commit()
    {
        _context.SaveChanges();
    }

}
