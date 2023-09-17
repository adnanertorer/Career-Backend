using Career.BusinessLayer.Abstracts.Repositories.BusinessAreaRepositories;
using Career.Core;
using Career.Core.Models;

namespace Career.BusinessLayer.Concrete.Repositories.BusinessAreaRepositories;

public class BusinessRepository:GenericRepository<BusinessArea>, IBusinessRepository
{
    protected BusinessRepository(CareerDbContext dbContext) : base(dbContext)
    {
    }
}