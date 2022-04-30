using System.ComponentModel.DataAnnotations;

namespace Library_Management_System.Models
{
    public class AdminLoginForm
    {
        [Required(ErrorMessage = "Enter the Admin Id.")]
        [Display(Name = "Admin Id")]
        public long Id { get; set; }

        [Required(ErrorMessage = "Enter the Admin Name.")]
        [Display(Name = "Admin Name")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter the password.")]
        [StringLength(50)]
        public string Password { get; set; }
    }
}