using Career.BusinessLayer.Abstracts.Repositories.MemberPersonalInformationRepositories;
using Career.Core;
using Career.Core.Models;

namespace Career.BusinessLayer.Concrete.Repositories.MemberPersonalInformationRepositories;

public class MemberPersonalInformationRepository:GenericRepository<MemberPersonalInformation>, IMemberPersonalInformationRepository
{
    protected MemberPersonalInformationRepository(CareerDbContext dbContext) : base(dbContext)
    {
    }
}