using Career.BusinessLayer.CustomModels;
using Career.Core.Models;

namespace Career.BusinessLayer.Abstracts.Repositories.AreaRepositories;

public interface IAreaRepository:IGenericRepository<City>
{
    Task<IEnumerable<DistrictModel>> GetDistrictList(int cityId);
}