using Domain.Interfaces;
using Domain.Models;
using Domain.Services.GenericsServices;
using Microsoft.AspNetCore.Mvc;

namespace DemoJwt.Controllers
{
    public class HomeController : Controller
    {
        private readonly IListServices<Product> _services;

        public HomeController(IListServices<Product> services)
        {
            _services = services;
        }

        [HttpGet("v1/api")]
        public IActionResult Index()
        {
            var products = _services.List();
            return Ok(products);
        }
    }
}
