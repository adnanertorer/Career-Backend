using Career.BusinessLayer.Abstracts.Repositories.EducationCriteriaRepositories;
using Career.Core;
using Career.Core.Models;

namespace Career.BusinessLayer.Concrete.Repositories.EducationCriteriaRepositories;

public class EducationCriteriaRepository:GenericRepository<EducationCriteria>, IEducationCriteriaRepository
{
    protected EducationCriteriaRepository(CareerDbContext dbContext) : base(dbContext)
    {
    }
}