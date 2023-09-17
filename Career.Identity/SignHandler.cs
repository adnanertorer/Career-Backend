using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Career.Identity;

public static class SignHandler
{
    public static SecurityKey GetSecurityKey(string securityKey)
    {
        return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
    }
}