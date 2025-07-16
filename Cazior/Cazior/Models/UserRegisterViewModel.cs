using System.ComponentModel.DataAnnotations;
using System;

namespace Cazior
{
    public class UserRegisterViewModel
    {
        [Required]
        public string FullName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, MinLength(6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
