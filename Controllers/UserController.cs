﻿using Library_Management_System.Models;
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
        /*
        [HttpPost]
        public ActionResult Login()
        {
            return View();
        }
        */
        public ActionResult Register()
        {
            var dept = _context.Department.ToList();

            RegistrationFormViewModel registration = new RegistrationFormViewModel
            {
                Registration = new Registration(),
                StudentDepartment = dept
            };
            return View(registration);
        }
        /*
        [HttpPost]
        public ActionResult Register()
        {
            return View();
        }*/
    }
}