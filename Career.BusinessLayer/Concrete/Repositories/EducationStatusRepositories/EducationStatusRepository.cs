using Career.BusinessLayer.Abstracts.Repositories.EducationStatusRepositories;
using Career.Core;
using Career.Core.Models;

namespace Career.BusinessLayer.Concrete.Repositories.EducationStatusRepositories;

public class EducationStatusRepository:GenericRepository<EducationStatus>, IEducationStatusRepository
{
    protected EducationStatusRepository(CareerDbContext dbContext) : base(dbContext)
    {
    }
}