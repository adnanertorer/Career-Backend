using Career.Core.Models;

namespace Career.Identity;

public interface ITokenHandler
{
    Task<AccessToken> CreateAccessToken(AdminUser resource);
    AccessToken? ReturnAccessToken(AdminUser resource);
    void RevokeRefreshToken(AdminUser resource);
}