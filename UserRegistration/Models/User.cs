using System.ComponentModel.DataAnnotations;

namespace UserRegistration.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "User Name is required.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }

        [Required(ErrorMessage = "IP Address is required.")]
        [MaxLength(15)]
        public string AllowedIP { get; set; }
    }
}
