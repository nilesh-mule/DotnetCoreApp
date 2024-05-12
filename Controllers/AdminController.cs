using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MVCApplication.Controllers
{
    public class AdminController : Controller
    {
        [Authorize(Policy = "RequireAdminRole")]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
