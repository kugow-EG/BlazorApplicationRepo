using BlazorApplication.Model;
using BlazorApplication.Repository.Interfaces;

namespace BlazorApplication.Repository
{
    public class LoginRepository : ILoginRepository
    {
        public async Task<bool> LoginUserAsync(LoginModel loginData)
        {
            // Logic to save the user data to the database can be added here
            return true;
        }
        public async Task<bool> ResetPasswordAsync(SignUpModel signupData)
        {
            // Logic to save the user data to the database can be added here
            return true;
        }
    }
}
