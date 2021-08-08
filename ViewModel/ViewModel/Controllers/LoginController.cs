using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewModel.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DoLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoLogin(string username, string password)
        {
            ViewBag.username = username;
            ViewBag.password = password;
            return Content("<p>Username: " +ViewBag.username + " Password: " +ViewBag.password+ "</p>");
        }
    }
}