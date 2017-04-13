using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentPortal.Models
{
    [MetadataType(typeof(TeacherPartial))]
    public partial class Teacher
    {

    }
    public class TeacherPartial
    {
        [Required]
        [Display(Name = "Teacher Name")]
        [RegularExpression("^[a-z A-Z]+$", ErrorMessage = "Invalid input")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Designation")]
        public string deg { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email { get; set; }
        [Required]
        public string Gender { get; set; }
        public int departId { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Addrs { get; set; }
        [Required]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNo { get; set; }

        public virtual Department Department { get; set; }
    }
}