using AutoMapper;
using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.OrderViewModels;

namespace BurgerApp.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IMapper _mapper;

        public OrderService(IRepository<Order> orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public List<OrderListViewModel> GetAllOrders()
        {
            return _orderRepository.GetAll().Select(_mapper.Map<Order, OrderListViewModel>).ToList();
        }

        public OrderDetailsViewModel GetOrderById(int id)
        {
            var order = _orderRepository.GetById(id);
            return _mapper.Map<Order, OrderDetailsViewModel>(order);
        }

        public void DeleteOrder(int id)
        {
            var order = _orderRepository.GetById(id);

            _orderRepository.Delete(id);
        }
    }
}
