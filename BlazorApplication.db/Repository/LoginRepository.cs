using BlazorApplication.Data.Data;
using BlazorApplication.Data.Entity;
using BlazorApplication.Repository.Interfaces;
using System.Data.Entity;

namespace BlazorApplication.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly DBContext _context;
        public LoginRepository(DBContext context)
        {
            _context = context;
        }
        public async Task<bool> LoginUserAsync(long phoneNumber, string password)
        {
            var user = await _context.Users.Select(u => u.PhoneNumber == phoneNumber || u.Password == password).FirstOrDefaultAsync();
            if (user != null )
            {
                return true;
            }
            return false;
        }
        public async Task<bool> ResetPasswordAsync(UserEntity userEntity)
        {
            // Logic to save the user data to the database can be added here
            return true;
        }
    }
}
