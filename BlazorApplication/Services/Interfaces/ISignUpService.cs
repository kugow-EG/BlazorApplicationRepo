using BlazorApplication.Model;

namespace BlazorApplication.Services.Interfaces
{
    public interface ISignUpService
    {
        public Task<bool> RegisterUserAsync(SignUpModel signupData);
    }
}