using AutoMapper;
using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.BurgerViewModels;
using BurgerApp.ViewModels.HomePageViewModels;

namespace BurgerApp.Services
{
    public class BurgerService : IBurgerService
    {
        private readonly IRepository<Burger> _burgerRepository;
        private readonly IMapper _mapper;

        public BurgerService(IRepository<Burger> burgerRepository, IMapper mapper)
        {
            _burgerRepository = burgerRepository;
            _mapper = mapper;
        }

        public List<BurgerListViewModel> GetAllBurgersForHomePage()
        {
            return _burgerRepository.GetAll().Select(_mapper.Map<Burger, BurgerListViewModel>).Take(3).ToList();
        }

        public List<BurgerListViewModel> GetAllBurgers()
        {
            return _burgerRepository.GetAll().Select(_mapper.Map<Burger, BurgerListViewModel>).ToList();
        }

    }
}
