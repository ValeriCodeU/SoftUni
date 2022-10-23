using System.ComponentModel.DataAnnotations;
using static Library.Data.DataConstants.ApplicationUser;

namespace Library.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(MaxUsername, MinimumLength = MinUsername)]

        public string UserName { get; set; } = null!;

        [Required]
        [StringLength(MaxEmaildLength, MinimumLength = MinEmailLength)]
        [EmailAddress]

        public string Email { get; set; } = null!;

        [Required]
        [StringLength(MaxPasswordLength, MinimumLength = MinPasswordLength)]
        [DataType(DataType.Password)]

        public string Password { get; set; } = null!;

        [Compare(nameof(Password))]
        [DataType(DataType.Password)]

        public string ConfirmPassword { get; set; } = null!;
    }
}
