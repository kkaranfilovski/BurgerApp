using AutoMapper;
using BurgerApp.Domain.Models;
using BurgerApp.ViewModels.UserViewModels;

namespace BurgerApp.Mappers
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<User, UserListViewModel>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));
        }
    }
}
