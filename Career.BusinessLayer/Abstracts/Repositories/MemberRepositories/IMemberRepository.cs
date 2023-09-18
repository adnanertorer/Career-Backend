using Career.BusinessLayer.CustomModels;
using Career.Core.Models;

namespace Career.BusinessLayer.Abstracts.Repositories.MemberRepositories;

public interface IMemberRepository:IGenericRepository<Member>
{
    Task<MemberModel?> FindByEmailAndPassword(MemberModel resource);
    Task SaveRefreshToken(MemberModel resource);
    Task<MemberModel?> GetUserWithRefreshToken(MemberModel resource);
    Task RemoveRefreshToken(MemberModel resource);
    Task<MemberModel> UpdateSummaryText(MemberModel resource);
    Task<StatusResource> ResetPassword(TempMemberInfo resource, int memberId);
    Task<MemberProfileImageModel> UploadProfileImage(MemberProfileImageModel resource);
    Task SetPassive(int memberId);
    Task SetActive(int memberId);
    Task SetAttention(int memberId);
    Task SetUnAttention(int memberId);
    Task SetPreferential(int memberId);
    Task SetUnPreferential(int memberId);
    Task<string?> GetProfileImage(int memberId);
    Task<IEnumerable<StaffNote>> GetStaffNotes(int userId, int memberId);
}