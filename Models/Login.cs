using System.ComponentModel.DataAnnotations;

namespace Library_Management_System.Models
{
    public class Login
    {
        [Required]
        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public string Designation { get; set; }
    }
}