using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemoJwt.Controllers
{
    public class HomeController : Controller
    {
        private readonly IListProductsServices _services;

        public HomeController(IListProductsServices services)
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
