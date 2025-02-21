using Microsoft.AspNetCore.Mvc;

namespace Student_Dashboard.Controllers
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
