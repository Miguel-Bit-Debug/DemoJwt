using Domain.Models;
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
            return Ok(new List<ProductModel> 
            {
                new ProductModel
                {
                    Name = "Danonão Grosso",
                    Price = 51
                },
                new ProductModel
                {
                    Name = "Bolu de murangu",
                    Price = 91
                },
                new ProductModel
                {
                    Name = "Xerebenebia",
                    Price = 100000
                }
            });
        }
    }
}
