using Career.BusinessLayer.CustomModels;
using Career.Core.Models;

namespace Career.BusinessLayer.Abstracts.Repositories.UserRepositories;

public interface IUserRepository:IGenericRepository<AdminUser>
{
    Task<AdminUser?> CheckUser(LoginModel resource);
    Task<AdminUser?> GetUserWithRefreshToken(LoginModel resource);
    Task RemoveRefreshToken(AdminUser resource);
    Task<StatusResource> UpdatePassword(PasswordResetModel resource, int id);
    Task<AdminUser> Add(AdminUser entity);
}