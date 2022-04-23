using System.ComponentModel.DataAnnotations;

namespace Library_Management_System.Models
{
    public class Author
    {
        public long Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }
}