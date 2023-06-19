using System.ComponentModel.DataAnnotations;

namespace Identity.DTO
{
    public class RegisterDTO
    {
        [Required (ErrorMessage = "Email Cannot Be Blank !")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Name Cannot Be Blank !")]
        [DataType (DataType.Text)]
        [RegularExpression("^[0-9]*$",ErrorMessage ="Phone number should contain numbers only")]
        public string PersonName { get; set; }
        [Required(ErrorMessage = "Phone Cannot Be Blank !")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Password Cannot Be Blank !")]
        [DataType (DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password Confirmation Cannot Be Blank !")]
        [DataType (DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
