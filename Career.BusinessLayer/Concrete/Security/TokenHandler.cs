using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using Career.BusinessLayer.Abstracts.Repositories.UserRepositories;
using Career.BusinessLayer.Abstracts.UnitOfWork;
using Career.Core.Models;
using Career.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Career.BusinessLayer.Concrete.Security;

public class TokenHandler:ITokenHandler
{
    private readonly TokenOptions _tokenOptions;
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;

    public TokenHandler(IOptions<TokenOptions> tokenOptions, IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _tokenOptions = tokenOptions.Value;
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }


    public async Task<AccessToken> CreateAccessToken(AdminUser resource)
    {
        var accessTokenExpiration = DateTime.Now.AddSeconds(_tokenOptions.AccessTokenExpiration);
        var securityKey = SignHandler.GetSecurityKey(_tokenOptions.SecurityKey);
        var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

        var jwtSecurityToken = new JwtSecurityToken(
            issuer: _tokenOptions.Issuer, audience: _tokenOptions.Audience, expires: accessTokenExpiration,
            notBefore: DateTime.Now, signingCredentials: signingCredentials, claims: GetClaims(resource));
        string token;
        try
        {
            var handler = new JwtSecurityTokenHandler();
            token = handler.WriteToken(jwtSecurityToken);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
           
        var accessToken = new AccessToken
        {
            Token = token,
            RefreshToken = CreateRefreshToken(),
            Expiration = accessTokenExpiration
        };
        resource.RefreshToken = accessToken.RefreshToken;
        resource.RefreshTokenEndDate = accessToken.Expiration;
        _userRepository.Update(resource);
        await _unitOfWork.CommitAsync();
        return accessToken;
    }

    public AccessToken? ReturnAccessToken(AdminUser resource)
    {
        if (resource.RefreshTokenEndDate != null)
        {
            var accessTokenExpiration = resource.RefreshTokenEndDate.Value;
            var securityKey = SignHandler.GetSecurityKey(_tokenOptions.SecurityKey);

            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _tokenOptions.Issuer, audience: _tokenOptions.Audience, expires: accessTokenExpiration,
                notBefore: DateTime.Now, signingCredentials: signingCredentials, claims: GetClaims(resource));

            var handler = new JwtSecurityTokenHandler();
            var token = handler.WriteToken(jwtSecurityToken);

            var accessToken = new AccessToken
            {
                Token = token,
                RefreshToken = resource.RefreshToken!,
                Expiration = accessTokenExpiration
            };
            return accessToken;
        }
        else
        {
            return null;
        }
    }

    public void RevokeRefreshToken(AdminUser resource)
    {
        resource.RefreshToken = null;
        _userRepository.Update(resource);
        _unitOfWork.Commit();
    }
    
    private static string CreateRefreshToken()
    {
        var numberByte = new byte[32];
        using var rnd = RandomNumberGenerator.Create();
        rnd.GetBytes(numberByte);
        return Convert.ToBase64String(numberByte);
    }

    private static IEnumerable<Claim> GetClaims(AdminUser resource)
    {
        var claims = new List<Claim> { new Claim(ClaimTypes.NameIdentifier, resource.Id.ToString()),
            new Claim(ClaimTypes.Role, "ADMIN"),
            new Claim(ClaimTypes.Email, resource.Email!),
            new Claim(ClaimTypes.Surname, resource.Surname),
            new Claim(ClaimTypes.Name, resource.Name),
            new Claim(ClaimTypes.MobilePhone, resource.Phone!),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())};
        return claims;
    }
}