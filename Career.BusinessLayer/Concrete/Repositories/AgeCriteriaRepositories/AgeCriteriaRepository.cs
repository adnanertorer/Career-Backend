using Career.BusinessLayer.Abstracts.Repositories.AgeCriteriaRepositories;
using Career.Core;
using Career.Core.Models;

namespace Career.BusinessLayer.Concrete.Repositories.AgeCriteriaRepositories;

public class AgeCriteriaRepository:GenericRepository<AgeCriteria>, IAgeCriteriaRepository
{
    protected AgeCriteriaRepository(CareerDbContext dbContext) : base(dbContext)
    {
    }
}