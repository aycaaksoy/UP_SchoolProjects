using System.ComponentModel.DataAnnotations;

namespace BaseIdentity.Presentation.Layer.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Cannot be empty")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Cannot be empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Cannot be empty")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Cannot be empty")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Cannot be empty")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Cannot be empty")]
        public string ConfirmPassword { get; set; }    
    }
}
