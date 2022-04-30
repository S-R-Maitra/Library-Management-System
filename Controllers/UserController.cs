using Library_Management_System.Models;
using Library_Management_System.ViewModel;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using System.Windows.Forms;

namespace Library_Management_System.Controllers
{
    public class UserController : Controller
    {

        private ApplicationDbContext _context;

        public UserController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StudentHomePage()
        {
            return View();
        }

        public ActionResult TeacherHomePage()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login login)
        {
            TempData["login"] = login;

            if (string.Equals(login.Designation, "Teacher"))
                return this.RedirectToAction("Teacher");

            else if (string.Equals(login.Designation, "Student"))
                return this.RedirectToAction("Student");

            return View(login);
        }

        public ActionResult Register()
        {
            var dept = _context.Department.ToList();
            var state = _context.IndianStatesAndUnionTerritories.ToList();

            RegistrationFormViewModel registration = new RegistrationFormViewModel
            {
                Registration = new Registration(),
                StudentDepartment = dept,
                StatesAndUT = state
            };
            return View(registration);
        }

        [HttpPost]
        public ActionResult Register(Registration registration)
        {

            if (string.Equals(registration.Designation, "Teacher"))
            {
                TeacherMember tm = new TeacherMember
                {
                    Name = registration.Name,
                    PhoneNo = registration.PhoneNo,
                    EmailId = registration.EmailId,
                    DateOfBirth = (System.DateTime)registration.DateOfBirth,
                    City = registration.City,
                    Pincode = registration.Pincode,
                    Password = registration.Password,
                    DepartmentID = registration.DepartmentID,
                    Address = registration.Address,
                    State = _context.IndianStatesAndUnionTerritories.SingleOrDefault(c => c.Id == registration.StateID).Name
                };
                _context.TeacherMember.Add(tm);
            }

            else if (string.Equals(registration.Designation, "Student"))
            {
                StudentMember sm = new StudentMember
                {
                    Name = registration.Name,
                    PhoneNo = registration.PhoneNo,
                    EmailId = registration.EmailId,
                    DateOfBirth = (System.DateTime)registration.DateOfBirth,
                    City = registration.City,
                    Pincode = registration.Pincode,
                    Password = registration.Password,
                    DepartmentID = registration.DepartmentID,
                    Address = registration.Address,
                    State = _context.IndianStatesAndUnionTerritories.SingleOrDefault(c => c.Id == registration.StateID).Name
                };
                _context.StudentMember.Add(sm);
            }

            _context.SaveChanges();

            return RedirectToAction("Login");

        }

        public ActionResult Student()
        {
            Login login = (Login)TempData["login"];

            var detail = _context.StudentMember.Include(m => m.Department).Where(m => m.Department.Id == m.DepartmentID).SingleOrDefault(m => m.Id == login.UserId);


            if (detail == null)
                return HttpNotFound();

            if (string.Equals(login.UserName, detail.Name) && string.Equals(login.Password, detail.Password))
            {
                ViewBag.UserDetails = detail;
                return View();
            }


            MessageBox.Show("Login failed!");

            return Content("" +
                "<script language='javascript' type='text/javascript'>" +
                    "alert('Login failed!');" +
                "</script>");
        }

        public ActionResult Teacher()
        {
            Login login = (Login)TempData["login"];

            var detail = _context.TeacherMember.Include(m => m.Department).Where(m => m.Department.Id == m.DepartmentID).SingleOrDefault(m => m.Id == login.UserId);


            if (detail == null)
                return HttpNotFound();

            if (string.Equals(login.UserName, detail.Name) && string.Equals(login.Password, detail.Password))
            {
                ViewBag.UserDetails = detail;
                return View();
            }


            MessageBox.Show("Login failed!");

            return Content("" +
                "<script language='javascript' type='text/javascript'>" +
                    "alert('Login failed!');" +
                "</script>");
        }
    }
}