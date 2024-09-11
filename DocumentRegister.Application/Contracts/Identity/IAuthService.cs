using DocumentRegister.Application.Models.Identity;

namespace DocumentRegister.Application.Contracts.Identity
{
    public interface IAuthService
	{
		Task<AuthResponse> Login(AuthRequest request);
		Task<RegistrationResponse> Register(RegistrationRequest request);
	}
}
