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
        private readonly IBurgerService _burgerService;

        public HomeController(ILogger<HomeController> logger, IBurgerService burgerService)
        {
            _logger = logger;
            _burgerService = burgerService;
        }

        public IActionResult Index()
        {
            var model = _burgerService.GetAllBurgersForHomePage();
            return View(model);
        }
    }
}