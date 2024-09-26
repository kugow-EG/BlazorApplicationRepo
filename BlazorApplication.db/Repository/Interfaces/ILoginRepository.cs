using BlazorApplication.Data.Entity;

namespace BlazorApplication.Repository.Interfaces
{
    public interface ILoginRepository
    {
        public Task<bool> LoginUserAsync(UserEntity userEntity);
        public Task<bool> ResetPasswordAsync(UserEntity userEntity);
    }
}