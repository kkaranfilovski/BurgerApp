using BurgerApp.DataAccess.Repositories;
using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Models;
using BurgerApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BurgerApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOrderService _orderService;

        public HomeController(ILogger<HomeController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            var model = _orderService.GetAllOrders();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}