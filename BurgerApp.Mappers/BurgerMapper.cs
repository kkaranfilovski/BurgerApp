using AutoMapper;
using BurgerApp.Domain.Models;
using BurgerApp.ViewModels.BurgerViewModels;

namespace BurgerApp.Mappers
{
    public class BurgerMapper : Profile
    {
        public BurgerMapper()
        {
            CreateMap<Burger, BurgerListViewModel>();
            CreateMap<Burger, BurgerDropdownViewModel>();
        }
    }
}
