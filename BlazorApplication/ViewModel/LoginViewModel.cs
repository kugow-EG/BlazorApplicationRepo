using BlazorApplication.Model;
using BlazorApplication.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorApplication.ViewModel
{
    public class LoginViewModel
    {
        private readonly ILoginService _loginService;
        private readonly NavigationManager _navigationManager;

        public LoginModel LoginData { get; set; } = new LoginModel();
        public SignUpModel SignupData { get; set; } = new SignUpModel();
        public string StatusMessage { get; set; }

        public LoginViewModel(ILoginService loginService, NavigationManager navigationManager)
        {
            _loginService = loginService;
            _navigationManager = navigationManager;
        }

        public async Task LoginAsync()
        {
            var success = await _loginService.LoginUserAsync(LoginData);
            if (success)
            {
                // Navigate to the home page or any other page
                _navigationManager.NavigateTo("/home");
            }
            else
            {
                StatusMessage = "Login failed. Please try again.";
            }
        }
        public async Task RequestPasswordResetAsync()
        { 
            var success = await _loginService.ResetPasswordAsync(SignupData);
            StatusMessage = success ? "Password Updated Successfully" : "Failed to reset password";            
        }    
    }
}
