using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Management_System.Models
{
    public class TeacherBookIssue
    {
        [Key]
        [Column(Order = 1)]
        public long MemberId { get; set; }

        [StringLength(50)]
        public string MemberName { get; set; }

        [Key]
        [Column(Order = 2)]
        public long BookId { get; set; }

        public string BookName { get; set; }

        [StringLength(50)]
        public string IssueDate { get; set; }

        [StringLength(50)]
        public string DueDate { get; set; }
    }
}