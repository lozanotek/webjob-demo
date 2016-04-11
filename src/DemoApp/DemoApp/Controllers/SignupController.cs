using System.Web.Mvc;

namespace DemoApp.Controllers
{
    public class SignupController : Controller
    {
        [HttpPost]
        public ActionResult Index(string email)
        {
            return RedirectToAction("index", "home");
        }
    }
}