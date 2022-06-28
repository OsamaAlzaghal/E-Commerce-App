using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Auth.Model.DTO
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "You have missed to fill the username")]
        [Display(Name = "User Name")]
        [MinLength(3)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
