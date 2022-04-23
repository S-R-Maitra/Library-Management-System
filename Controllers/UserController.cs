using System.Web.Mvc;

namespace Library_Management_System.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        /*
        [HttpPost]
        public ActionResult Login()
        {
            return View();
        }
        */
        public ActionResult Register()
        {
            return View();
        }
        /*
        [HttpPost]
        public ActionResult Register()
        {
            return View();
        }*/
    }
}