using System.Reflection.Metadata;

namespace ChatIARag.API.Interface.Repository;

public interface IDocumentRepository
{
    Task<List<Document>> GetAllAsync();
    Task<Document?> GetByIdAsync(Guid id);
    Task CreateAsync(Document document);
    Task<Document?> UpdateAsync(Document document);
    Task DeleteAsync(Guid id);
}
