using Career.BusinessLayer.Abstracts.Repositories.MemberRepositories;
using Career.BusinessLayer.Abstracts.UnitOfWork;
using Career.BusinessLayer.CustomModels;
using Career.BusinessLayer.Tools;
using Career.Core;
using Career.Core.Models;
using Career.Identity;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Career.BusinessLayer.Concrete.Repositories.MemberRepositories;

public class MemberRepository : GenericRepository<Member>, IMemberRepository
{
    private readonly TokenOptions _tokenOptions;
    private readonly IUnitOfWork _unitOfWork;

    protected MemberRepository(CareerDbContext dbContext, IOptions<TokenOptions> tokenOptions, IUnitOfWork unitOfWork) : base(dbContext)
    {
        _unitOfWork = unitOfWork;
        _tokenOptions = tokenOptions.Value;
    }

    [Obsolete("Obsolete")]
    public async Task<MemberModel?> FindByEmailAndPassword(MemberModel resource)
    {
        var member = await DbContext.Members.FirstOrDefaultAsync(i => i.Email.Equals(resource.Email) &&
                                                                      i.Password.Equals(resource.Password));
        if (member is { PasswordSalt: { } } && Encryptor.IsValid(resource.Password, member.PasswordSalt))
        {
            return member.Adapt<MemberModel>();
        }
        else
        {
            return null;
        }
    }

    public async Task SaveRefreshToken(MemberModel resource)
    {
        var member = await GetById(resource.Id);
        member!.RefreshToken = resource.RefreshToken;
        member.RefreshTokenEndDate = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
    }

    public async Task<MemberModel?> GetUserWithRefreshToken(MemberModel resource)
    {
        var member = await DbContext.Members.FirstOrDefaultAsync(i =>
            i.RefreshToken != null && i.RefreshToken.Equals(resource.RefreshToken));
        return member?.Adapt<MemberModel>();
    }

    public async Task RemoveRefreshToken(MemberModel resource)
    {
        var member = await DbContext.Members.FirstOrDefaultAsync(i => i.RefreshToken == resource.RefreshToken);
        member!.RefreshToken = null;
        member.RefreshTokenEndDate = null;
    }

    public async Task<MemberModel> UpdateSummaryText(MemberModel resource)
    {
        var member = await GetById(resource.Id);
        member!.SummaryText = resource.SummaryText;
        return member.Adapt<MemberModel>();
    }

    [Obsolete("Obsolete")]
    public async Task<StatusResource> ResetPassword(TempMemberInfo resource, int memberId)
    {
        var member = await GetById(memberId);
        var oldPassword = member!.PasswordSalt;
        if (Encryptor.IsValid(resource.OldPassword, oldPassword) && member.Password == Encryptor.HashPassword(resource.OldPassword))
        {
            var newPass = Encryptor.HashPassword(resource.Password);
            member.PasswordSalt = newPass;
            Update(member);
            return new StatusResource() { Status = true, StatusInt = 1, DynamicClass = member };
        }
        else
        {
            return new StatusResource() { Status = false, StatusInt = -1 };
        }
    }

    public async Task<MemberProfileImageModel> UploadProfileImage(MemberProfileImageModel resource)
    {
        var member = await GetById(resource.Id);
        member!.ProfileImage = resource.ImageName;
        Update(member);
        await _unitOfWork.CommitAsync();
        return resource;
    }

    public async Task SetPassive(int memberId)
    {
        var member = await GetById(memberId);
        member!.IsBlocked = true;
        member.Preferential = false;
        member.IsActive = false;
        Update(member);
    }

    public async Task SetActive(int memberId)
    {
        var member = await GetById(memberId);
        member!.IsActive = true;
        member.IsBlocked = false;
        Update(member);
    }

    public async Task SetAttention(int memberId)
    {
        var member =  await GetById(memberId);
        member!.Attention = true;
        member.Preferential = false;
        Update(member);
    }

    public async Task SetUnAttention(int memberId)
    {
        var member = await GetById(memberId);
        member!.Attention = false;
        Update(member);
    }

    public async Task SetPreferential(int memberId)
    {
        var member = await GetById(memberId);
        member!.Preferential = true;
        member.Attention = false;
        Update(member);
    }

    public async Task SetUnPreferential(int memberId)
    {
        var member = await GetById(memberId);
        member!.Preferential = false;
        Update(member);
    }

    public async Task<string?> GetProfileImage(int memberId)
    {
        var member = await GetById(memberId);
        return member?.ProfileImage;
    }

    public async Task<IEnumerable<StaffNote>> GetStaffNotes(int userId, int memberId)
    {
        return await DbContext.StaffNotes.Where(i => i.MemberId == memberId && i.CreatedBy == userId)
            .Include(i => i.Member).ToListAsync();
    }
}