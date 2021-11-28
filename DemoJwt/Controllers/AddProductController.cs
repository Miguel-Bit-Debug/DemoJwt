using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DemoJwt.Controllers
{
    [Route("v1/add")]
    public class AddProductController : ControllerBase
    {

        [HttpPost]
        public async Task<ActionResult> Index()
        {
            return Created("/", "");
        }
    }
}
