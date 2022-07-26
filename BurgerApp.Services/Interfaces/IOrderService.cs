using BurgerApp.ViewModels.OrderViewModels;

namespace BurgerApp.Services.Interfaces
{
    public interface IOrderService
    {
        List<OrderListViewModel> GetAllOrders();
        OrderDetailsViewModel GetOrderById(int id);
        OrderViewModel GetOrderForEdit(int id);
        void CreateOrder(OrderViewModel orderViewModel);
        void DeleteOrder(int id);
        void EditOrder(OrderViewModel orderViewModel);
    }
}
