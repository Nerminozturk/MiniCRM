using MiniCRM.Application.DTOs;

namespace MiniCRM.Application.Interfaces;

public interface IAuthService
{
    Task RegisterAsync(UserRegisterDto dto);
    Task<string> LoginAsync(UserLoginDto dto);
}
