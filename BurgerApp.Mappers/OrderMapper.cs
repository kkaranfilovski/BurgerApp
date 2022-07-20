using AutoMapper;
using BurgerApp.Domain.Models;
using BurgerApp.ViewModels.OrderViewModels;

namespace BurgerApp.Mappers
{
    public class OrderMapper : Profile
    {
        public OrderMapper()
        {
            CreateMap<Order, OrderListViewModel>()
                .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.UserFullName, opt => opt.MapFrom(src => $"{src.User.FirstName} {src.User.LastName}"));
        }
    }
}
