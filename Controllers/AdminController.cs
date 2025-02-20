using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CampusJobsProject___Group_34.Controllers
{
  //  [Authorize(Roles = "Admin")]  Requires the user to be authenticated and in the "Admin" role
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
