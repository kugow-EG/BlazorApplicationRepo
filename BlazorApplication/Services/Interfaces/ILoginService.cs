using BlazorApplication.Model;

namespace BlazorApplication.Services.Interfaces
{
    public interface ILoginService
    {
        public Task<bool> LoginUserAsync(LoginModel loginData);
        public Task<bool> ResetPasswordAsync(SignUpModel signupData);
    }
}