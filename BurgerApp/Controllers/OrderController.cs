using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.OrderViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IBurgerService _burgerService;
        private readonly IUserService _userService;

        public OrderController(IOrderService orderService, IBurgerService burgerService, IUserService userService)
        {
            _orderService = orderService;
            _burgerService = burgerService;
            _userService = userService;
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
            ViewBag.Users = _userService.GetUsersForDropdown();
            ViewBag.Burgers = _burgerService.GetBurgersForDropdown();
            var model = new OrderViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(OrderViewModel orderViewModel)
        {
            ViewBag.Users = _userService.GetUsersForDropdown();
            ViewBag.Burgers = _burgerService.GetBurgersForDropdown();

            if(ModelState.IsValid)
            {
                _orderService.CreateOrder(orderViewModel);
                return RedirectToAction("AllOrders");
            }
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
            if (id == null)
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
