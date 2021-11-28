using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Infra.Data.Entities
{
    public class UserLoginModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
