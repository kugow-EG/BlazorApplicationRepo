using AutoMapper;
using BlazorApplication.Data.Entity;
using BlazorApplication.Model;
using BlazorApplication.Repository.Interfaces;
using BlazorApplication.Services.Interfaces;

namespace BlazorApplication.Services
{
    public class SignUpService : ISignUpService
    {
        private readonly ISignUpRepository _signUpRepository;
		private readonly IMapper mapper;

		public SignUpService(ISignUpRepository signUpRepository , IMapper mapper)
        {
            _signUpRepository = signUpRepository;
			this.mapper = mapper;
		}

        public async Task<bool> RegisterUserAsync(SignUpModel signupData)
        {
			var userEntity = mapper.Map<UserEntity>(signupData);
            // Logic to validate the input or check for existing users can be added here
            var sts = await _signUpRepository.CreateUserAsync(userEntity);
            return sts;
        }

    }
}
