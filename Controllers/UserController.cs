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
            string cont = "";
            cont += "User Id : " + login.UserId + "<br>";
            cont += "User Name : " + login.UserName + "<br>";
            cont += "User Designation : " + login.Designation + "<br>";
            cont += "User Password : " + login.Password + "<br>";

            return Content(cont);
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
                    DateOfBirth = (System.DateTime)registration.DateOfBirth
                };
            }

            /*
            var dName = _context.Department.SingleOrDefault(c => c.Id == registration.DepartmentID);
            string cont = "";
            cont += "Name : " + registration.Name + "<br>";
            cont += "Designation : " + registration.Designation + "<br>";
            cont += "Phone No : " + registration.PhoneNo + "<br>";
            cont += "Password : " + registration.Password + "<br>";
            cont += "Confirm Password : " + registration.ConfirmPassword + "<br>";
            cont += "Email Id : " + registration.EmailId + "<br>";
            cont += "Department Name : " + dName.Name + "<br>";
            */
            return View();
        }
    }
}