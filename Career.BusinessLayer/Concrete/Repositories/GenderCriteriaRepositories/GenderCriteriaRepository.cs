using Career.BusinessLayer.Abstracts.Repositories.GenderCriteriaRepositories;
using Career.Core;
using Career.Core.Models;

namespace Career.BusinessLayer.Concrete.Repositories.GenderCriteriaRepositories;

public class GenderCriteriaRepository:GenericRepository<GenderCriteria>, IGenderCriteriaRepository
{
    protected GenderCriteriaRepository(CareerDbContext dbContext) : base(dbContext)
    {
    }
}