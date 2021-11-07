using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Infra.Data.Entities
{
    public class UserRegisterEntity
    {
        [DataType(DataType.EmailAddress)]
        public string Avatar { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
    }
}
