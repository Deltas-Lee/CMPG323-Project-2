using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ORGANISATION_X.Models
{
    public partial class LoginModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [DataType(DataType.PhoneNumber)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter the Confirm Password.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
        public string Name { get; set; }
    }
}
