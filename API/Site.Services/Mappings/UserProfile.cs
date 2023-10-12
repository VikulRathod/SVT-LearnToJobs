using AutoMapper;
using Site.Data.Entities;
using Site.Models;

namespace Site.Services.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserSignUpModel>()
           .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
           .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
           .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
           .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
           .ForMember(dest => dest.Role, opt => opt.Ignore())
           .ForMember(dest => dest.ConfirmPassword, opt => opt.Ignore())
           .ReverseMap();
        }
    }
}
