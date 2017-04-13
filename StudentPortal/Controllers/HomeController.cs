using Microsoft.AspNet.Identity;
using StudentPortal.Models;
using System.Web.Mvc;

namespace StudentPortal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {

            ViewBag.Message = "Daffodil International University.";

            return View();
        }


        public ActionResult RoleAdd()
        {
            UserRoleDB userRole = new UserRoleDB();
            AspNetUserRole ur = new AspNetUserRole();
            ur.RoleId = TempData["Role"].ToString();
            ur.UserId = User.Identity.GetUserId();
            userRole.AspNetUserRoles.Add(ur);
            userRole.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Contuct Information.";

            return View();
        }
    }
}