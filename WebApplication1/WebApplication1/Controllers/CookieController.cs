using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CookieController : Controller
    {
        // GET: Cookie
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Set()
        {
            HttpCookie cookie = new HttpCookie("myCookie");
            cookie["favColor"] = "red";
            cookie.Expires = DateTime.Now.AddDays(6);
            cookie["expdate"] = cookie.Expires.ToString();
            Response.Cookies.Add(cookie);
            return View();
        }

        public ActionResult Get()
        {
            var cookie = Request.Cookies["myCookie"];
            if (cookie == null)
            {
                return Content("<h1>Cookie not found<h1>");
            }
            ViewBag.favColor = cookie["favColor"];
            ViewBag.timeout = cookie["expdate"];
            return View();
        }
    }
}