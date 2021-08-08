using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ApplicationController : Controller
    {
        // GET: Application
        public ActionResult Index()
        {
            if (HttpContext.Application["count"] == null)
            {
                HttpContext.Application["count"] = 0;
            }
            ViewBag.oldValue = (int)HttpContext.Application["count"];
            HttpContext.Application["count"] = (int)HttpContext.Application["count"] + 1;
            ViewBag.applicationId = HttpContext.Session.SessionID;
            return View();
            
        }
    }
}