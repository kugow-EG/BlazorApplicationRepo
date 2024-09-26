using BlazorApplication.Data.Entity;
using BlazorApplication.Repository.Interfaces;

namespace BlazorApplication.Repository
{
    public class LoginRepository : ILoginRepository
    {
        public async Task<bool> LoginUserAsync(UserEntity userEntity)
        {
            // Logic to save the user data to the database can be added here
            return true;
        }
        public async Task<bool> ResetPasswordAsync(UserEntity userEntity)
        {
            // Logic to save the user data to the database can be added here
            return true;
        }
    }
}
