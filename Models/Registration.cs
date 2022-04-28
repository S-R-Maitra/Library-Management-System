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
        [RegularExpression("^\\d{10}$", ErrorMessage = "Enter the contact number in proper format.")]
        public long? PhoneNo { get; set; }

        [Required]
        [Display(Name = "Mail id")]
        [EmailAddress(ErrorMessage = "Enter a valid mail ID")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Please enter the date of birth")]
        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Enter the city name.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter the pincode.")]
        public string Pincode { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public IndianStatesAndUnionTerritories IndianStatesAndUnionTerritories { get; set; }
        [Display(Name = "State / UT")]
        public int StateID { get; set; }


        public Department Department { get; set; }

        [ForeignKey("Department")]
        [Display(Name = "Department")]
        public long DepartmentID { get; set; }

    }
}