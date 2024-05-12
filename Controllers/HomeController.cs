using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCApplication.EF;
using MVCApplication.Models;
using System.Diagnostics;

namespace MVCApplication.Controllers
{
    public class HomeController : Controller
    {
        private _repositary _Repositary = null;

        private readonly DatabaseContext _databaseContext;
       
        public HomeController(DatabaseContext  databaseContext, _repositary Repo)
        {
           _databaseContext = databaseContext;
            _Repositary= Repo;
        }
        public IList<ApplicationUser> UseDen() {

            return _Repositary.Getdaitails();
        }
        public IActionResult GetData()
        {
           var data = _databaseContext.EmpTable.ToList();
            
            return View(data);
        }
        [HttpGet("/user/{id}")]
        public IActionResult Getbyid(int id) { 
        
           var db= _databaseContext.EmpTable.FirstOrDefault(x => x.Id == id);
            if (db == null)
            {
                return NotFound();
            }
           
            return PartialView("_UserDetailsPartial", db);
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
        public IActionResult Demopage()
        {
            ViewData["Name"] = "Nilesh";
            ViewBag.Name = "Nilesh Mule";
            TempData["Nilesh"] = "Mule";
            return View();
        }
        [Authorize]
        public IActionResult TempPage()
        {
            //if (id == 12)
            //{
            //    // If id is 12, pass TempData["Nilesh"] to the view
            //    var message = TempData["Nilesh"];
            //    return View(message);
            //}
            //else
            //{
            //    // If id is not 12, set ViewData["check"] and render the view
            //    ViewData["check"] = "This is the viewdata";
            //    return View();
            //}
            return View();

        }
        // GET: /Account/Login
        //[AllowAnonymous]
        //public IActionResult Login(string returnUrl = null)
        //{
        //    ViewData["ReturnUrl"] = returnUrl;
        //    return View();
        //}

        // POST: /Account/Login
        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // Implement your login logic here
        //        // Example: verify user credentials, set authentication cookie, etc.
        //        // If login is successful, redirect the user
        //        return RedirectToLocal(returnUrl);
        //    }

        //    // If we got this far, something failed, redisplay form
        //    return View(model);
        //}

        // Helper method to redirect user after successful login
        //private IActionResult RedirectToLocal(string returnUrl)
        //{
        //    if (Url.IsLocalUrl(returnUrl))
        //    {
        //        return Redirect(returnUrl);
        //    }
        //    else
        //    {
        //        return RedirectToAction(nameof(HomeController.Index), "Home");
        //    }
        //}

    }
}
