namespace ChatIARag.API.Interface.Repository;

public interface IUnitOfWork
{
    Task Commit();
    void Rollback();
}
