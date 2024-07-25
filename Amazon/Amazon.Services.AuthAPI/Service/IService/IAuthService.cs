using Amazon.Services.AuthAPI.Dtos;

namespace Amazon.Services.AuthAPI.Service.IService
{
    public interface IAuthService
    {
        Task<UserDto> Register (RegistrationRequestDto registrationRequestDto);
        Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
    }
}
