using System.ComponentModel.DataAnnotations;

namespace BlazorDemoUI.Models
{
    public class DisplayPersonModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Too long. 50 max")]
        [MinLength(2, ErrorMessage = "Too short. 2 min")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Too long. 50 max")]
        [MinLength(2, ErrorMessage = "Too short. 2 min")]
        public string LastName { get; set; }
        [Required]
        [MinLength(6, ErrorMessage ="Too short. 10 min")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
