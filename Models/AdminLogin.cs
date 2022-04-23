using System.ComponentModel.DataAnnotations;

namespace Library_Management_System.Models
{
    public class AdminLogin
    {
        [Key]
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(50)]
        public string FullName { get; set; }
    }
}