using Career.BusinessLayer.Abstracts.UnitOfWork;
using Career.Core;

namespace Career.BusinessLayer.Concrete.UnitOfWork;

public class UnitOfWork:IUnitOfWork
{
    private readonly CareerDbContext _dbContext;

    public UnitOfWork(CareerDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task CommitAsync()
    {
        await _dbContext.SaveChangesAsync();
    }

    public void Commit()
    {
        _dbContext.SaveChanges();
    }
}