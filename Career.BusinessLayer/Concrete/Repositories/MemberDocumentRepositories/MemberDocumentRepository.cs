using Career.BusinessLayer.Abstracts.Repositories.MemberDocumentRepositories;
using Career.Core;
using Career.Core.Models;

namespace Career.BusinessLayer.Concrete.Repositories.MemberDocumentRepositories;

public class MemberDocumentRepository:GenericRepository<MemberDocument>,IMemberDocumentRepository
{
    protected MemberDocumentRepository(CareerDbContext dbContext) : base(dbContext)
    {
    }
}