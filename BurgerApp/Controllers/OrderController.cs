using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.OrderViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IBurgerService _burgerService;

        public OrderController(IOrderService orderService, IBurgerService burgerService)
        {
            _orderService = orderService;
            _burgerService = burgerService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllOrders()
        {
            var model = _orderService.GetAllOrders();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _orderService.GetOrderById(id);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id)
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            if(id == null)
            {
                return View("BadRequest");
            }
            var model = _orderService.GetOrderById(id);
            return View(model);
        }

        public IActionResult ConfirmDelete(int id)
        {
            var model = _orderService.GetOrderById(id);
            _orderService.DeleteOrder(model.OrderId);
            return RedirectToAction("AllOrders");
        }
    }
}
