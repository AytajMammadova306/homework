using CoffeeShopAPI.Application.DTOs.Auth;

namespace CoffeeShopAPI.Application.Interfaces.Services
{
    public interface IAuthService
    {
        Task<LoginResponseDto?> LoginAsync(LoginRequestDto request);
    }
}
