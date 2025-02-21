using Microsoft.AspNetCore.Mvc;

namespace CampusJobsProject___Group_34.Controllers
{
    public class HomepageController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Homepage";
            return View();
        }
    }
}
