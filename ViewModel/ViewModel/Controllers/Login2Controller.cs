using System.Web.Mvc;
using ViewModel.Models;

namespace ViewModel.Controllers
{
    public class Login2Controller : Controller
    {
        // GET: Login2
        [HttpGet]
        public ActionResult Index()
        {
            LoginViewModel vm = new LoginViewModel();
            vm.Username = "shreyabhr";
            vm.Password = "1234";
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel vm)
        {
            Session["username"] = vm.Username;
            if (vm.Username == null|| vm.Password == null)
            {
                ModelState.AddModelError(nameof(vm.Username), "username not entered");
                ModelState.AddModelError(nameof(vm.Password), "password not entered");
                return View(vm);
            }
            return RedirectToAction("Index","Welcome");
        }
    }
}