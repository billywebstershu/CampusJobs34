using Microsoft.AspNetCore.Mvc;

namespace Student_Dashboard.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Profile";
            return View();
        }
    }
}
