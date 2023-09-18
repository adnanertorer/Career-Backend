using Career.BusinessLayer.Abstracts.Repositories.CompanyEmployeeRequestRepositories;
using Career.BusinessLayer.CustomModels;
using Career.Core;
using Career.Core.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Career.BusinessLayer.Concrete.Repositories.CompanyEmployeeRequestRepositories;

public class CompanyEmployeeRequestRepository:GenericRepository<CompanyEmployeeRequest>, ICompanyEmployeeRequestRepository
{
    protected CompanyEmployeeRequestRepository(CareerDbContext dbContext) : base(dbContext)
    {
    }

    public async Task AddWithProf(CompanyEmployeeRequestModel resource, List<ProfessionModel> resources)
    {
        var model = resource.Adapt<CompanyEmployeeRequest>();
        await DbContext.CompanyEmployeeRequests.AddAsync(model);
        foreach (var companyWantAdMainProfession in resources.Select(item => new CompanyEmployeeRequestProfession()
                 {
                     ProfessionId = item.Id,
                     CompanyRequestId = model.Id
                 }))
        {
            await DbContext.CompanyEmployeeRequestProfessions.AddAsync(companyWantAdMainProfession);
        }
    }

    public async Task<IEnumerable<CompanyEmployeeRequestModel>> GetListByCompany(int companyId)
    {
        var list =  await DbContext.CompanyEmployeeRequests.Where(i => i.CompanyId == companyId)
            .Include(i => i.Category)
            .Include(i => i.AgeCriteria)
            .Include(i => i.Company)
            .Include(i => i.EducationCriteria)
            .Include(i => i.GenderCriteria)
            .Include(i => i.WorkingType)
            .ToListAsync();
        return list.Adapt<IEnumerable<CompanyEmployeeRequestModel>>();
    }
}