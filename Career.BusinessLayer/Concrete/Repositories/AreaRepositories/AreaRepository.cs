using Career.BusinessLayer.Abstracts.Repositories.AreaRepositories;
using Career.BusinessLayer.CustomModels;
using Career.Core;
using Career.Core.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Career.BusinessLayer.Concrete.Repositories.AreaRepositories;

public class AreaRepository:GenericRepository<City>, IAreaRepository
{
    protected AreaRepository(CareerDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<IEnumerable<DistrictModel>> GetDistrictList(int cityId)
    {
        var list = await DbContext.Districts.Where(i => i.CityId == cityId).OrderBy(i => i.DistrictName).ToListAsync();
        return list.Adapt<IEnumerable<DistrictModel>>();
    }
}