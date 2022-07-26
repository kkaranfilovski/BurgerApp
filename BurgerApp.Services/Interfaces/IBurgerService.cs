using BurgerApp.ViewModels.BurgerViewModels;

namespace BurgerApp.Services.Interfaces
{
    public interface IBurgerService
    {
        List<BurgerListViewModel> GetAllBurgersForHomePage();
        List<BurgerListViewModel> GetAllBurgers();
        List<BurgerDropdownViewModel> GetBurgersForDropdown();
    }
}
