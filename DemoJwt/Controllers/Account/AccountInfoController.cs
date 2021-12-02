using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DemoJwt.Controllers.Account
{
    [Route("v1/AccountInfo")]
    public class AccountInfoController : ControllerBase
    {
        private readonly IAccountInfoService _service;

        public AccountInfoController(IAccountInfoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult> Index([FromBody] AccountInfoPayload payload)
        {
            var user = await _service.FindAccountByEmail(payload.Email);

            return Ok(user);
        }
    }

    public class AccountInfoPayload
    {
        public string Email { get; set; }
    }
}
