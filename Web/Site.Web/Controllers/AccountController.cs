using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Web.API.Client.Services.Account;

namespace Site.Web.Controllers
{
    public class AccountController : Controller
    {
        IAuthApiController _authApi;

        public AccountController(IAuthApiController authApi)
        {
            _authApi = authApi;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserSignUpModel model)
        {
            if (ModelState.IsValid)
            {
                _authApi.Register(model);
                return RedirectToAction("Login");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                UserModel user = _authApi.Validate(model);
                if (user.Roles.Contains("Admin"))
                {
                    return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                }
                else if (user.Roles.Contains("User"))
                {
                    return RedirectToAction("Index", "Dashboard", new { area = "User" });
                }

                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
