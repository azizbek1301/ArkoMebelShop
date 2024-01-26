using Authorisation.API.Models;

namespace Authorisation.API.Interfaces
{
    public interface IAuthService
    {
        ValueTask<string> GenerateToken(Login login);
    }
}
