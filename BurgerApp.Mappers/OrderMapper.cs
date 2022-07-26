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
                .ForMember(dest => dest.UserFullName, opt => opt.MapFrom(src => $"{src.User.FirstName} {src.User.LastName}"))
                .ForMember(dest => dest.Burgers, opt => opt.MapFrom(src => src.BurgerOrders.Select(x => x.Burger.Name).ToList()));

            CreateMap<Order, OrderDetailsViewModel>()
                .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.UserFullName, opt => opt.MapFrom(src => $"{src.User.FirstName} {src.User.LastName}"))
                .ForMember(dest => dest.Burgers, opt => opt.MapFrom(src => src.BurgerOrders.Select(x => x.Burger.Name).ToList()))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.User.Address))
                .ForMember(dest => dest.TotalPrice, opt => opt.MapFrom(src => src.BurgerOrders.Select(x => x.Burger.Price).ToList().Sum()))
                .ForMember(dest => dest.status, opt => opt.MapFrom(src => src.IsDelivered));

            CreateMap<Order, OrderViewModel>().ReverseMap();
        }
    }
}
