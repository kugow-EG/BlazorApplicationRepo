using BlazorApplication.Model;
using BlazorApplication.Repository.Interfaces;
using BlazorApplication.Services.Interfaces;

namespace BlazorApplication.Services
{
    public class SignUpService : ISignUpService
    {
        private readonly ISignUpRepository _signUpRepository;

        public SignUpService(ISignUpRepository signUpRepository)
        {
            _signUpRepository = signUpRepository;
        }

        public async Task<bool> RegisterUserAsync(SignUpModel signupData)
        {
            // Logic to validate the input or check for existing users can be added here
            return await _signUpRepository.CreateUserAsync(signupData);
        }

    }
}
