using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Management_System.Models
{
    public class Registration
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public string Designation { get; set; }

        [Required]
        [Display(Name = "Contact Number")]
        public long? PhoneNo { get; set; }

        [Required]
        [Display(Name = "Mail id")]
        public string EmailId { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        public Department Department { get; set; }

        [ForeignKey("Department")]
        [Display(Name = "Department")]
        public long DepartmentID { get; set; }

    }
}