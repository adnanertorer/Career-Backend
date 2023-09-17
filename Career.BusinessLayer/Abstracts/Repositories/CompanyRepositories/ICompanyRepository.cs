using Career.BusinessLayer.CustomModels;
using Career.Core.Models;

namespace Career.BusinessLayer.Abstracts.Repositories.CompanyRepositories;

public interface ICompanyRepository:IGenericRepository<Company>
{
    Task<CompanyEmployeeRequestModel> AddRequest(CompanyEmployeeRequestModel resource);
    Task<IEnumerable<CompanyEmployeeRequestModel>> CompanyEmployeeRequestList(int companyId);
    Task<IEnumerable<MemberJobRequestModel>> CompanyEmployeeRequestMemberList(int memberId);
}