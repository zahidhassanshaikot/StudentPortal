using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentPortal.Models
{
    [MetadataType(typeof(RegistrationPartial))]
    public partial class AspNetUser
    {

    }
    public class RegistrationPartial
    {
        [Required]
        [Display(Name = "Student Name")]
        [RegularExpression("^[a-z A-Z]+$",ErrorMessage="Invalid input")]
        public string FullName { get; set; }
        [Required]
 
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
       
        [Required]
        public string Address { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Invalid input")]
        public int Age { get; set; }
        [Required]
        public string BloodGroup { get; set; }
        [Required]
        [Phone(ErrorMessage="Invalid phone number")]
        
        public string PhoneNo { get; set; }
        [Required]
        [Display(Name = "Date of birth")]
        public string DOB { get; set; }
        [Required]
        [Display(Name = "Date of Admition")]
        public string DOA { get; set; }
        [Required]
        public string UserName { get; set; }
    }
}