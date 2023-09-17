using Career.BusinessLayer.Abstracts.Repositories.UserRepositories;
using Career.BusinessLayer.CustomModels;
using Career.BusinessLayer.Tools;
using Career.Core;
using Career.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Career.BusinessLayer.Concrete.Repositories.UserRepositories;

public class UserRepository:GenericRepository<AdminUser>,IUserRepository
{
    protected UserRepository(CareerDbContext dbContext) : base(dbContext)
    {
    }

    [Obsolete("Obsolete")]
    public async Task<AdminUser?> CheckUser(LoginModel resource)
    {
        var user =
            await DbContext.AdminUsers.FirstOrDefaultAsync(i =>
                i.Email == resource.Email);
        if (user == null)
        {
            return null;
        }
        else if(user.PasswordSalt != null && Encryptor.IsValid(resource.Password, user.PasswordSalt))
        {
            return user;
        }
        else
        {
            return null;
        }
    }

    public async Task<AdminUser?> GetUserWithRefreshToken(LoginModel resource)
    {
        return await DbContext.AdminUsers.AsNoTracking().FirstOrDefaultAsync(i => i.RefreshToken!.Equals(resource.RefreshToken));
    }

    public async Task RemoveRefreshToken(AdminUser resource)
    {
        var user = await GetById(resource.Id);
        user!.RefreshToken = null;
        DbContext.Update(user);
    }

    [Obsolete("Obsolete")]
    public async Task<StatusResource> UpdatePassword(PasswordResetModel resource, int id)
    {
        var user = await GetById(id);
        var oldPassword = user!.PasswordSalt;
        if (oldPassword != null && Encryptor.IsValid(resource.OldPassword, oldPassword) && user.Password == Encryptor.HashPassword(resource.OldPassword))
        {
            var newPass = Encryptor.HashPassword(resource.NewPassword);
            user.PasswordSalt = newPass;
            Update(user);
            return new StatusResource() { Status = true, StatusInt = 1, DynamicClass = user };
        }
        else
        {
            return new StatusResource() { Status = false, StatusInt = -1 };
        }
    }

    [Obsolete("Obsolete")]
    public async Task<AdminUser> Add(AdminUser entity)
    {
        entity.Password = Encryptor.Md5Hash(entity.Password!);
        entity.PasswordSalt = Encryptor.HashPassword(entity.Password);
        return await Save(entity);
    }
}