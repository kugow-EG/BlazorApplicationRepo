using BlazorApplication.Model;
using BlazorApplication.Services.Interfaces;

namespace BlazorApplication.ViewModel
{
    public class LoginViewModel
    {
        private readonly ILoginService _loginService;
        
        public LoginModel LoginData { get; set; } = new LoginModel();
        public SignUpModel SignupData { get; set; } = new SignUpModel();
        public string StatusMessage { get; set; }

        public LoginViewModel(ILoginService loginService)
        {
            _loginService = loginService;
        }

        public async Task LoginAsync()
        {
            var success = await _loginService.LoginUserAsync(LoginData);
            StatusMessage = success ? "Login successful!" : "Invalid Phone Number or Password";
        }
        public async Task RequestPasswordResetAsync()
        { 
            var success = await _loginService.ResetPasswordAsync(SignupData);
            StatusMessage = success ? "Password Updated Successfully" : "Failed to reset password";            
        }    
    }
}
