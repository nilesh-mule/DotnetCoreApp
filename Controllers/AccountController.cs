using Microsoft.AspNetCore.Mvc;

namespace MVCApplication.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
