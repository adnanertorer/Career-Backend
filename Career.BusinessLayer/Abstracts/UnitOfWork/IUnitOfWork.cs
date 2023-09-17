namespace Career.BusinessLayer.Abstracts.UnitOfWork;

public interface IUnitOfWork
{
    Task CommitAsync();
    void Commit();
}