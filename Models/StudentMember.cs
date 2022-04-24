using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Management_System.Models
{
    public class StudentMember
    {
        [Key]
        public long Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }
        public long? PhoneNo { get; set; }
        public string EmailId { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public Department Department { get; set; }

        [ForeignKey("Department")]
        public long DepartmentID { get; set; }
    }
}