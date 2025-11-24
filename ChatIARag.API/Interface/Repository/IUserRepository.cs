using ChatIARag.API.Models;

namespace ChatIARag.API.Interface.Repository;

public interface IUserRepository
{
    ValueTask<User> GetByIdAsync(Guid id);
    ValueTask<bool> IsEmailAvailableAsync(string email);
    Task<User> GetByEmailAsync(string email);
    Task CreateAsync (User user);
    Task UpdateAsync (User user);

}
