using ChatIARag.API.Data.Context;
using ChatIARag.API.Interface.Repository;
using ChatIARag.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatIARag.API.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ChatIARagDbContext _context;
    private readonly IUnitOfWork _unitOfWork;
    public UserRepository(ChatIARagDbContext context, IUnitOfWork unitOfWork)
    {
        _context = context;
        _unitOfWork = unitOfWork;
    }

    public async Task CreateAsync(User user)
    {
        await _context.User.AddAsync(user);
        await _unitOfWork.Commit();
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return await _context.User.ToListAsync();
    }

    public async Task<User> GetByEmailAsync(string email)
    {
       return await _context.User.FirstOrDefaultAsync(u => u.Email == email);
    }

    public async ValueTask<User> GetByIdAsync(Guid id)
    {
        return await _context.User.FindAsync(id);
    }

    public async ValueTask<bool> IsEmailAvailableAsync(string email)
    {
        return !await _context.User.AnyAsync(u => u.Email == email);
    }

    public async ValueTask<bool> IsUsernameAvailableAsync(string username)
    {
        return !await _context.User.AnyAsync(u => u.Name == username);
    }

    public async Task UpdateAsync(User user)
    {
        await Task.FromResult(_context.User.Update(user));
        await _unitOfWork.Commit();
    }
}
