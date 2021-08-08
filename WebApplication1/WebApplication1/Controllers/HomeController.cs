using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome()
        {
            return View();
        }

        public ActionResult Welcome1(string developer)
        {
            ViewBag.name = developer;
            return View();
        }

        public ActionResult Welcome2(string developer)
        {
            if(developer != "")
            {
                return Content("<h1>hello " + developer + "</h1>");
            }
            return Content("<h1>hello</h1>");
        }

        public ActionResult Login()
        {           
            
            return View();
        }

        public ActionResult Welcome3(string name)
        {
            if(name != null)
            {
                return Json(new { Name = name, Company = "AurionPro" }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { Name = "shreya", Company = "AurionPro" },JsonRequestBehavior.AllowGet);
        }

        public ActionResult Auth(FormCollection form)
        {
            ViewBag.name = form["username"];
            ViewBag.password = form["password"];
            return View();
        }
    }
}