//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentPortal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string deg { get; set; }
        public string email { get; set; }
        public string Gender { get; set; }
        public int departId { get; set; }
        public string Addrs { get; set; }
        public string PhoneNo { get; set; }
    
        public virtual Department Department { get; set; }
    }
}