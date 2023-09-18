using Career.BusinessLayer.CustomModels;
using Career.Core.Models;

namespace Career.BusinessLayer.Abstracts.Repositories.CompanyEmployeeRequestRepositories;

public interface ICompanyEmployeeRequestRepository:IGenericRepository<CompanyEmployeeRequest>
{
    Task AddWithProf(CompanyEmployeeRequestModel resource, List<ProfessionModel> resources);
    Task<IEnumerable<CompanyEmployeeRequestModel>> GetListByCompany(int companyId);
}