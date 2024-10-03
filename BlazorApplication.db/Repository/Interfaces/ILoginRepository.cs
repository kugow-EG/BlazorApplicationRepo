using BlazorApplication.Data.Entity;

namespace BlazorApplication.Repository.Interfaces
{
    public interface ILoginRepository
    {
        public Task<bool> LoginUserAsync(long phoneNumber, string password);
        public Task<bool> ResetPasswordAsync(long phoneNumber, string newPassword);
    }
}