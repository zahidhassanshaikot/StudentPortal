using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentPortal.Models
{

    [MetadataType(typeof(ResultPartial))]
    public partial class Result
    {

    }
    public class ResultPartial
    {
        [Required]
        public string Subject { get; set; }
       
        [Required]
        [Display(Name = "GPA")]
        public string Mark { get; set; }
    }
}