using System;
using API.DTOs;
using API.Entiries;
using API.Interfaces;

namespace API.Extensions;

public static class AppUserExtentions
{
    public static UserDto ToDto(this AppUser user, ITokenService tokenService)
    {
        if (user == null) throw new ArgumentNullException(nameof(user));

        return new UserDto
        {
            Id = user.Id,
            Email = user.Email,
            DisplayName = user.DisplayName,
            Token = tokenService.CreateToken(user)
        };
    }
}
