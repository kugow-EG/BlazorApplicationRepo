using BlazorApplication.Data.Data;
using BlazorApplication.Data.Entity;
using BlazorApplication.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

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
            var user = await _context.Users.Where(u => u.PhoneNumber == phoneNumber && u.Password == password).FirstOrDefaultAsync();

            if (user != null )
            {
                return true;
            }
            return false;
        }
        public async Task<bool> ResetPasswordAsync(long phoneNumber, string newPassword)
        {
            var userEntity = await _context.Users.FirstOrDefaultAsync(u => u.PhoneNumber == phoneNumber);
            if (userEntity == null)
                return false;
            userEntity.Password = newPassword;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
