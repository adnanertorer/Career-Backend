using Career.BusinessLayer.CustomModels;
using Career.Core.Models;

namespace Career.BusinessLayer.Abstracts.Repositories.MemberRepositories;

public interface IMemberRepository:IGenericRepository<Member>
{
    Task<MemberModel> FindByEmailAndPassword(MemberModel resource);
    Task SaveRefreshToken(MemberModel resource);
    Task<MemberModel> GetUserWithRefreshToken(MemberModel resource);
    Task RemoveRefreshToken(MemberModel resource);
    Task<MemberModel> UpdateSummaryText(MemberModel resource);
    Task<StatusResource> ResetPassword(TempMemberInfo resource);
    Task<MemberProfileImageModel> UploadProfileImage(MemberProfileImageModel resource);
    Task SetPassive(int memberId, int adminId);
    Task Recover(int memberId, int adminId);
    Task SetActive(int memberId, int adminId);
    Task SetAttention(int memberId, int adminId);
    Task SetUnAttention(int memberId, int adminId);
    Task SetPreferential(int memberId, int adminId);
    Task SetUnPreferential(int memberId, int adminId);
    Task<string> GetProfileImage(int memberId);
    Task<IEnumerable<StaffNote>> GetStaffNotes(int userId, int memberId);
}