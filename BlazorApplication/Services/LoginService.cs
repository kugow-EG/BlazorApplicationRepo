using BlazorApplication.Model;
using BlazorApplication.Repository.Interfaces;
using BlazorApplication.Services.Interfaces;

namespace BlazorApplication.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public async Task<bool> LoginUserAsync(LoginModel loginData)
        {
            // Logic to validate the input or check for existing users can be added here
            return await _loginRepository.LoginUserAsync(loginData);
        }
        public async Task<bool> ResetPasswordAsync(SignUpModel signupData)
        {
            return await _loginRepository.ResetPasswordAsync(signupData);
        }

    }
}
