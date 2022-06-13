using Library_Management_System.Models;
using System.Linq;
using System.Web.Mvc;

namespace Library_Management_System.Controllers
{
    public class AdminController : Controller
    {

        private ApplicationDbContext _context;

        public AdminController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Admin

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AdminLoginForm login)
        {
            var details = _context.AdminLogin.SingleOrDefault(m => m.Id == login.Id);

            if (details == null)
                return HttpNotFound();

            if (string.Equals(details.Name, login.Name) && string.Equals(details.Password, login.Password))
            {
                ViewBag.Details = details;
                return View("~/Views/Admin/Admin.cshtml");
            }


            return Content("Admin Login failed");
        }

        public ActionResult AddUsers()
        {
            return RedirectToAction("User/Register");
        }


    }
}