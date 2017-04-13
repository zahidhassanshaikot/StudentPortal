using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentPortal.Models
{
    [MetadataType(typeof(StudentPartial))]
    public partial class Student
    {

    }
    public class StudentPartial
    {
        [Required]
        [Display(Name = "Student Name")]
        [RegularExpression("^[a-z A-Z]+$", ErrorMessage = "Invalid input")]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [Display(Name = "Department Nmae")]
        public int DepartId { get; set; }
        [Required]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Invalid input")]
        public Nullable<int> Age { get; set; }
        [Required]
        public string BloodGroup { get; set; }
        [Required]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNo { get; set; }
        [Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required]
        [Display(Name="Date of Birth")]
 
        public Nullable<System.DateTime> DOB { get; set; }
        [Required]
        [Display(Name = "Date of Admision")]
        public Nullable<System.DateTime> DOA { get; set; }
        [Required]
        public string Addrs { get; set; }
   
    }
}