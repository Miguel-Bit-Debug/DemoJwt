using DemoJwt.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DemoJwt.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [HttpGet("v1/api")]
        public IActionResult Index()
        {
            var users = new List<UserModel>
            {
                new UserModel
                {
                    Email = "teste@gmail.com",
                    Password = "01452136542336"
                }
            };
            return Ok(users);
        }
    }
}
