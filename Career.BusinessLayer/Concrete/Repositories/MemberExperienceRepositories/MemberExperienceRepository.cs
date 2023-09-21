using Career.BusinessLayer.Abstracts.Repositories.MemberExperienceRepositories;
using Career.Core;
using Career.Core.Models;

namespace Career.BusinessLayer.Concrete.Repositories.MemberExperienceRepositories;

public class MemberExperienceRepository:GenericRepository<MemberExperience>, IMemberExperienceRepository
{
    protected MemberExperienceRepository(CareerDbContext dbContext) : base(dbContext)
    {
    }
}