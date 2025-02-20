using Microsoft.AspNetCore.Mvc;

namespace Student_Dashboard.Controllers
{
    public class NotificationsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Notifications";
            return View();
        }
    }
}
