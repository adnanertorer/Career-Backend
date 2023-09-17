using Career.BusinessLayer.Abstracts.Repositories.CategoryRepositories;
using Career.Core;
using Career.Core.Models;

namespace Career.BusinessLayer.Concrete.Repositories.CategoryRepositories;

public class CategoryRepository:GenericRepository<Category>, ICategoryRepository
{
    protected CategoryRepository(CareerDbContext dbContext) : base(dbContext)
    {
    }
}