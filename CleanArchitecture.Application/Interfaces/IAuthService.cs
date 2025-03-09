using CleanArchitecture.Application.DTOs.Auth;
using CleanArchitecture.Application.Features.Auth.Commands;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IAuthService
    {
        Task<RegistrationResponse> RegisterAsync(RegisterRequest request);
        Task<bool> ConfirmEmailAsync(string userId, string token);
        Task<AuthResponse> LoginAsync(LoginRequest request);
        Task<ForgotPasswordResponse> ForgotPasswordAsync(string email);
        Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordRequest request);
    }
}