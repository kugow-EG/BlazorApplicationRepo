using BlazorApplication.Data.Entity;
using BlazorApplication.Repository.Interfaces;

namespace BlazorApplication.Repository
{
    public class SignUpRepository : ISignUpRepository
    {
        public async Task<bool> CreateUserAsync(UserEntity signupData)
        {
            // Logic to save the user data to the database can be added here
            return true;
        }
    }
}
