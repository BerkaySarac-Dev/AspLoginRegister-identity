using LoginRegisterApp.Enums;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LoginRegisterApp.DTO
{
    public class RegisterDTO
    {
        [BindProperty]
        [Required (ErrorMessage = "Email Cannot Be Blank !")]
        [EmailAddress(ErrorMessage = " Email should be in a proper email address format")]
        [Remote(action:"IsEmailAlreadyRegistered" , controller:"Account" , ErrorMessage = "Email is already registered")]
        public string Email { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "Name Cannot Be Blank !")]
        public string PersonName { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "Phone Cannot Be Blank !")]
        public string Phone { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "Password Cannot Be Blank !")]
        [DataType (DataType.Password)]
        public string Password { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "Password Confirmation Cannot Be Blank !")]
        [DataType (DataType.Password)]
        [Compare("Password",ErrorMessage = "Passwords Should be same")]
        public string ConfirmPassword { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "Wallet Code  Cannot Be Blank !")]
        [DataType(DataType.Text)]
        public string CryptoWalletCode { get; set; }

        public UserTypeOptions UserType { get; set; } = UserTypeOptions.User;
    }
}
