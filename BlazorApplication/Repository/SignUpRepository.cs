using BlazorApplication.Model;
using BlazorApplication.Repository.Interfaces;

namespace BlazorApplication.Repository
{
    public class SignUpRepository : ISignUpRepository
    {
        public async Task<bool> CreateUserAsync(SignUpModel signupData)
        {
            // Logic to save the user data to the database can be added here
            return true;
        }
    }
}
