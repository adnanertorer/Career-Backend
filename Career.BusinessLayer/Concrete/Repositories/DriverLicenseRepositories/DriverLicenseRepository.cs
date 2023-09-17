using Career.BusinessLayer.Abstracts.Repositories.DriverLicenseRepositories;
using Career.Core;
using Career.Core.Models;

namespace Career.BusinessLayer.Concrete.Repositories.DriverLicenseRepositories;

public class DriverLicenseRepository:GenericRepository<DriverLicense>, IDriverLicenseRepository
{
    protected DriverLicenseRepository(CareerDbContext dbContext) : base(dbContext)
    {
    }
}