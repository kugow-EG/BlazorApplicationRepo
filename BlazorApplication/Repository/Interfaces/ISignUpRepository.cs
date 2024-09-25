using BlazorApplication.Model;

namespace BlazorApplication.Repository.Interfaces
{
    public interface ISignUpRepository
    {
        public Task<bool> CreateUserAsync(SignUpModel signupData);
    }
}