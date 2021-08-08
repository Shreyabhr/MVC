using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult Index()
        {
            if(Session["count"] == null)
            {
                Session["count"] = 0;
            }           
            ViewBag.oldValue = (int)Session["count"];
            Session["count"] = (int)Session["count"] + 1;
            ViewBag.sessionId = HttpContext.Session.SessionID;
            return View();
        }
    }
}