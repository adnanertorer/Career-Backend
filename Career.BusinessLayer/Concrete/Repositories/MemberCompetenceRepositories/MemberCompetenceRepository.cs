using Career.BusinessLayer.Abstracts.Repositories.MemberCompetenceRepositories;
using Career.Core;
using Career.Core.Models;

namespace Career.BusinessLayer.Concrete.Repositories.MemberCompetenceRepositories;

public class MemberCompetenceRepository:GenericRepository<MemberCompetence>, IMemberCompetenceRepository
{
    protected MemberCompetenceRepository(CareerDbContext dbContext) : base(dbContext)
    {
    }
}