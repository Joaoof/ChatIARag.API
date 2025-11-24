using ChatIARag.API.Models;

namespace ChatIARag.API.Interface.Repository;

public interface IMessageRepository
{
    Task<List<Document>> GetAllAsync();
    Task<Document> GetByIdAsync(Guid id);
    Task CreateAsync(Document document);
    Task UpdateAsync(Document document);
    Task DeleteAsync(Guid id);
}
