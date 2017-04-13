using Microsoft.AspNet.Identity.EntityFramework;

namespace StudentPortal.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }

        //public string Email { get; set; }


        public string Address { get; set; }
        public string Gender { get; set; }

        public string Department { get; set; }
        public int Age { get; set; }

        public string BloodGroup { get; set; }

        public string PhoneNo { get; set; }

        public string DOB { get; set; }

        public string DOA { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DBcon")
        {
        }
    }
}