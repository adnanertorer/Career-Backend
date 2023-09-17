using Career.BusinessLayer.Abstracts.Repositories.GenderRepositories;
using Career.Core;
using Career.Core.Models;

namespace Career.BusinessLayer.Concrete.Repositories.GenderRepositories;

public class GenderRepository:GenericRepository<GenderType>, IGenderRepository
{
    protected GenderRepository(CareerDbContext dbContext) : base(dbContext)
    {
    }
}