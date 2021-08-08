using System.Web.Mvc;
using ViewModel.AuthData;
using ViewModel.Models;

namespace ViewModel.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Login3
        [HttpGet]
        [RecordTime]
        public ActionResult Index()
        {
            return View(new RegistrationViewModel());
        }

        [HttpPost]
        public ActionResult Index(RegistrationViewModel vm)
        {
            if (!this.ModelState.IsValid)
            {
                return View(vm);
            }
            string thankYouMsg = "Thank your for registering " + vm.Name;
            return Content(thankYouMsg);
        }
    }
}