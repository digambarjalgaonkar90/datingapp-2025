using API.Entiries;

namespace API.Interfaces;

public interface ITokenService
{
    string CreateToken(AppUser user);
}
