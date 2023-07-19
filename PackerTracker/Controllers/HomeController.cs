using Microsoft.AspNetCore.Mvc;

namespace PackerTracker.Controllers {
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}