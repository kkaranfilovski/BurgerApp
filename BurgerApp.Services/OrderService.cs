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
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Burger> _burgerRepository;
        private readonly IMapper _mapper;

        public OrderService(IRepository<Order> orderRepository, IMapper mapper, IRepository<User> userRepository, IRepository<Burger> burgerRepository)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _userRepository = userRepository;
            _burgerRepository = burgerRepository;
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

        public void CreateOrder(OrderViewModel orderViewModel)
        {
            var user = _userRepository.GetById(orderViewModel.UserId);

            foreach (var id in orderViewModel.BurgerId)
            {
                var burger = _burgerRepository.GetById(id);
                orderViewModel.BurgerOrders.Add(new BurgerOrder() { BurgerId = burger.Id, OrderId = orderViewModel.Id });   
            }

            var order = _mapper.Map<Order>(orderViewModel);
            _orderRepository.Insert(order);
        }
    }
}
