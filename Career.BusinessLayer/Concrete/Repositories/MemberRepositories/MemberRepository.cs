using Career.BusinessLayer.Abstracts.Repositories.MemberRepositories;
using Career.BusinessLayer.CustomModels;
using Career.Core;
using Career.Core.Models;

namespace Career.BusinessLayer.Concrete.Repositories.MemberRepositories;

public class MemberRepository:GenericRepository<Member>, IMemberRepository
{
    protected MemberRepository(CareerDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<MemberModel> FindByEmailAndPassword(MemberModel resource)
    {
        throw new NotImplementedException();
    }

    public async Task SaveRefreshToken(MemberModel resource)
    {
        throw new NotImplementedException();
    }

    public async Task<MemberModel> GetUserWithRefreshToken(MemberModel resource)
    {
        throw new NotImplementedException();
    }

    public async Task RemoveRefreshToken(MemberModel resource)
    {
        throw new NotImplementedException();
    }

    public async Task<MemberModel> UpdateSummaryText(MemberModel resource)
    {
        throw new NotImplementedException();
    }

    public async Task<StatusResource> ResetPassword(TempMemberInfo resource)
    {
        throw new NotImplementedException();
    }

    public async Task<MemberProfileImageModel> UploadProfileImage(MemberProfileImageModel resource)
    {
        throw new NotImplementedException();
    }

    public async Task SetPassive(int memberId, int adminId)
    {
        throw new NotImplementedException();
    }

    public async Task Recover(int memberId, int adminId)
    {
        throw new NotImplementedException();
    }

    public async Task SetActive(int memberId, int adminId)
    {
        throw new NotImplementedException();
    }

    public async Task SetAttention(int memberId, int adminId)
    {
        throw new NotImplementedException();
    }

    public async Task SetUnAttention(int memberId, int adminId)
    {
        throw new NotImplementedException();
    }

    public async Task SetPreferential(int memberId, int adminId)
    {
        throw new NotImplementedException();
    }

    public async Task SetUnPreferential(int memberId, int adminId)
    {
        throw new NotImplementedException();
    }

    public async Task<string> GetProfileImage(int memberId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<StaffNote>> GetStaffNotes(int userId, int memberId)
    {
        throw new NotImplementedException();
    }
}