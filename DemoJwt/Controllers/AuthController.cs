using Domain.Models;
using Infra.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DemoJwt.Controllers
{
    [Route("v1/auth")]
    public class AuthController : Controller
    {
        private readonly UserManager<IdentityUserModel> _userManager;
        private readonly SignInManager<IdentityUserModel> _signInManager;

        private readonly JwtSettings _jwtSettings;

        public AuthController(IOptions<JwtSettings> jwtSettings,
                              UserManager<IdentityUserModel> userManager,
                              SignInManager<IdentityUserModel> signInManager)
        {
            _jwtSettings = jwtSettings.Value;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<UserTokenModel>> Index([FromBody] UserLoginModel user)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.Values);

            var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, false, true);

            if (result.Succeeded)
            {
                var token = GenerateAccessToken(user.Email);

                return new UserTokenModel
                {
                    Token = token
                };
            }

            return BadRequest("Usuário ou senha inválidos.");
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserTokenModel>> Register([FromBody] UserRegisterModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.Values);

            if (model.Email is null || model.Password is null)
            {
                return BadRequest("Por favor preencher todas as informações.");
            }

            var user = new IdentityUserModel
            {
                Avatar = model.Avatar,
                Email = model.Email,
                UserName = model.Email,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);

                var token = GenerateAccessToken(user.Email);

                return new UserTokenModel
                {
                    Token = token
                };

            }

            return BadRequest();
        }

        private string GenerateAccessToken(string email)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_jwtSettings.SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, email),
                }),
                Audience = _jwtSettings.Audience,
                Issuer = _jwtSettings.Issuer,
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
