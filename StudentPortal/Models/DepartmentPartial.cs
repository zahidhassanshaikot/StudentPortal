using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentPortal.Models
{
    [MetadataType(typeof(DepartmentPartial))]
    public partial class Department
    {

    }
    public class DepartmentPartial
    {
        
        [Display(Name = "Dipartment Name")]
        public string Name { get; set; }
    }
}