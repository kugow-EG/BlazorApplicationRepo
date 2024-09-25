using BlazorApplication.Model;
using BlazorApplication.Services.Interfaces;

namespace BlazorApplication.ViewModel
{
    public class SignUpViewModel
    {
        private readonly ISignUpService _signUpService;
        public SignUpModel SignupData { get; set; } = new SignUpModel();
        public bool StatusMessage { get; set; }

        public SignUpViewModel(ISignUpService signUpService)
        {
            _signUpService = signUpService;
        }

        public async Task SignupAsync()
        {        
            var success = await _signUpService.RegisterUserAsync(SignupData);
            StatusMessage = success ? true : false;           
        }
    }
}
