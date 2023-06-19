using System.ComponentModel.DataAnnotations;

namespace LoginRegisterApp.DTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Email can't be blank")]
        [EmailAddress(ErrorMessage = "Email should be in a proper email address format")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Password Can't be blank")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
