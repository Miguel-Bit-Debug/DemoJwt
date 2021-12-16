using Domain.Interfaces.GenericsInterfaces;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DemoJwt.Controllers
{
    [Authorize]
    [Route("v1/add")]
    public class AddProductController : ControllerBase
    {
        private readonly IAddService<Product> _service;

        public AddProductController(IAddService<Product> service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult> Index([FromBody] Product product)
        {
            await _service.Insert(product);
            return Ok();
        }
    }
}
