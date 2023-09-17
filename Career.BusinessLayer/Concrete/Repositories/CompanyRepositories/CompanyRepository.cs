using System.Collections;
using Career.BusinessLayer.Abstracts.Repositories.CompanyRepositories;
using Career.BusinessLayer.CustomModels;
using Career.Core;
using Career.Core.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Career.BusinessLayer.Concrete.Repositories.CompanyRepositories;

public class CompanyRepository:GenericRepository<Company>, ICompanyRepository
{
    protected CompanyRepository(CareerDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<CompanyEmployeeRequestModel> AddRequest(CompanyEmployeeRequestModel resource)
    {
        await DbContext.CompanyEmployeeRequests.AddAsync(resource.Adapt<CompanyEmployeeRequest>());
        return resource;
    }

    public async Task<IEnumerable<CompanyEmployeeRequestModel>> CompanyEmployeeRequestList(int companyId)
    {
        var list = await DbContext.CompanyEmployeeRequests.Where(i => i.CompanyId == companyId)
            .Include(i => i.Company).Include(i => i.Category)
            .Include(i => i.AgeCriteria).Include(i => i.EducationCriteria)
            .Include(i => i.GenderCriteria).Include(i => i.WorkingType)
            .ToListAsync();
        return list.Adapt<IEnumerable<CompanyEmployeeRequestModel>>();
    }

    public async Task<IEnumerable<MemberJobRequestModel>> CompanyEmployeeRequestMemberList(int memberId)
    {
        var list = await DbContext.MemberJobRequests.Where(i=>i.MemberId == memberId).Include(i=>i.Member).Include(i=>i.CompanyEmployeeRequest).
            OrderByDescending(i => i.CreatedAt).ToListAsync();
        return list.Adapt<IEnumerable<MemberJobRequestModel>>();
    }
}