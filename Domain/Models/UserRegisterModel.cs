using System.ComponentModel.DataAnnotations;

namespace Infra.Data.Entities
{
    public class UserRegisterModel
    {
        [Required]
        public string Avatar { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PasswordConfirmation { get; set; }
    }
}
