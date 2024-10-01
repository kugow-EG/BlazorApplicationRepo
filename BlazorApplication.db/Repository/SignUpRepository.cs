using BlazorApplication.Data.Data;
using BlazorApplication.Data.Entity;
using BlazorApplication.Repository.Interfaces;

namespace BlazorApplication.Repository
{        
    public class SignUpRepository : ISignUpRepository
    {
        private readonly DBContext _context;
        public SignUpRepository(DBContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateUserAsync(UserEntity signupData)
        {
            await _context.Users.AddAsync(signupData);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
