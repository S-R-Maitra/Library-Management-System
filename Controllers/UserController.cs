using Library_Management_System.Models;
using Library_Management_System.ViewModel;
using System.Linq;
using System.Web.Mvc;

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

            return Content("Registration Successful!");

            //string cont = "";
            //cont += "Name : " + registration.Name + "<br>";
            //cont += "Designation : " + registration.Designation + "<br>";
            //cont += "Phone No : " + registration.PhoneNo + "<br>";
            //cont += "Password : " + registration.Password + "<br>";
            //cont += "Confirm Password : " + registration.ConfirmPassword + "<br>";
            //cont += "Email Id : " + registration.EmailId + "<br>";
            //cont += "Department Name : " + _context.Department.SingleOrDefault(c => c.Id == registration.DepartmentID).Name + "<br>";
            //cont += "Date of Birth : " + registration.DateOfBirth;
            //return Content(cont);
        }

        public ActionResult Student()
        {
            Login login = (Login)TempData["login"];

            var details = _context.StudentMember.SingleOrDefault(c => c.Id == login.UserId);
            if (details == null)
                return HttpNotFound();

            if (string.Equals(login.UserName, details.Name) && string.Equals(login.Password, details.Password))
                return Content("Login Successful");

            return Content("Login failed!");
        }

        public ActionResult Teacher()
        {
            Login login = (Login)TempData["login"];

            var details = _context.TeacherMember.SingleOrDefault(c => c.Id == login.UserId);
            if (details == null)
                return HttpNotFound();

            if (string.Equals(login.UserName, details.Name) && string.Equals(login.Password, details.Password))
                return Content("Login Successful");

            return Content("Login failed!");
        }
    }
}