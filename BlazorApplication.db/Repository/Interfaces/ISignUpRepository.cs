using BlazorApplication.Data.Entity;

namespace BlazorApplication.Repository.Interfaces
{
    public interface ISignUpRepository
    {
        public Task<bool> CreateUserAsync(UserEntity signupData);
    }
}