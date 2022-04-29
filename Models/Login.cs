using System.ComponentModel.DataAnnotations;

namespace Library_Management_System.Models
{
    public class Login
    {
        [Required(ErrorMessage = "UserID is required")]
        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please provide a designation.")]
        public string Designation { get; set; }
    }
}