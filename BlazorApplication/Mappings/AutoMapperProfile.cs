using AutoMapper;
using BlazorApplication.Data.Entity;
using BlazorApplication.Model;

namespace BlazorApplication.Mappings
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile() 
		{
			CreateMap<SignUpModel, UserEntity>().ReverseMap();
			CreateMap<LoginModel, UserEntity>().ReverseMap();
		}
	}
}
