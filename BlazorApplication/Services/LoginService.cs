using AutoMapper;
using BlazorApplication.Data.Entity;
using BlazorApplication.Model;
using BlazorApplication.Repository.Interfaces;
using BlazorApplication.Services.Interfaces;

namespace BlazorApplication.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;
		private readonly IMapper mapper;

		public LoginService(ILoginRepository loginRepository , IMapper mapper)
        {
            _loginRepository = loginRepository;
			this.mapper = mapper;
		}

        public async Task<bool> LoginUserAsync(LoginModel loginData)
        {
            var userEntity = mapper.Map<UserEntity>(loginData);
            // Convert PhoneNumber from long to string
            return await _loginRepository.LoginUserAsync(userEntity.PhoneNumber, userEntity.Password);
        }
        public async Task<bool> ResetPasswordAsync(SignUpModel signupData)
        {
			var userEntity = mapper.Map<UserEntity>(signupData);
			return await _loginRepository.ResetPasswordAsync(userEntity);
        }

    }
}
