using AutoMapper;
using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.OrderViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var orders = _orderRepository.GetAll();
            
            var orderListViewModel = orders.Select(_mapper.Map<Order, OrderListViewModel>).ToList();
            var a = 5;
            return orderListViewModel;
        }
    }
}
