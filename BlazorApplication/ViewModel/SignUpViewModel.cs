using BlazorApplication.Model;
using BlazorApplication.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorApplication.ViewModel
{
    public class SignUpViewModel
    {
        private readonly ISignUpService _signUpService;

        private readonly NavigationManager _navigationManager;
        public SignUpModel SignupData { get; set; } = new SignUpModel();
        public string StatusMessage { get; set; }

        public SignUpViewModel(ISignUpService signUpService, NavigationManager navigationManager)
        {
            _signUpService = signUpService;
            _navigationManager = navigationManager;
        }

        public async Task SignupAsync()
        {        
            var success = await _signUpService.RegisterUserAsync(SignupData);
            if (success)
            {
                // Navigate to the home page or any other page
                _navigationManager.NavigateTo("/Login");
            }
            else
            {
                StatusMessage = "Login failed. Please try again.";
            }
        }
        public async Task LoginAsync()
        {
           _navigationManager.NavigateTo("/Login");           
        }
    }
}
