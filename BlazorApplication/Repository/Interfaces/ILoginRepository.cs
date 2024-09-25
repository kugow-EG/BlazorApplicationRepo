using BlazorApplication.Model;

namespace BlazorApplication.Repository.Interfaces
{
    public interface ILoginRepository
    {
        public Task<bool> LoginUserAsync(LoginModel loginData);
        public Task<bool> ResetPasswordAsync(SignUpModel signupData);
    }
}