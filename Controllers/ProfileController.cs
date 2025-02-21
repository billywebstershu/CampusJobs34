using Microsoft.AspNetCore.Mvc;

namespace CampusJobsProject___Group_34.Controllers
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
