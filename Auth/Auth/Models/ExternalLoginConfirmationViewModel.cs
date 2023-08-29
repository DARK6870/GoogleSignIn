using System.ComponentModel.DataAnnotations;

namespace Auth.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }

}
