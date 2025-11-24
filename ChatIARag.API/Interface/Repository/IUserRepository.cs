using ChatIARag.API.Models;

namespace ChatIARag.API.Interface.Repository;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllAsync();
    ValueTask<User> GetByIdAsync(Guid id);
    ValueTask<bool> IsEmailAvailableAsync(string email);
    ValueTask<bool> IsUsernameAvailableAsync(string username);
    Task<User> GetByEmailAsync(string email);   
    Task CreateAsync (User user);
    Task UpdateAsync (User user);
}
