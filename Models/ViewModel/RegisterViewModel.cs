using System.ComponentModel.DataAnnotations;

namespace Identity.Models.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(255)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(25)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(25)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }
    }
}
