using System.Threading.Tasks;
using StudentDiary.Services.DTOs;

namespace StudentDiary.Services.Interfaces;

public interface IAuthService
{
    Task<UserResponse> RegisterAsync(RegisterRequest request);
    Task<UserResponse?> LoginAsync(LoginRequest request);
}
