using App.Data.Entity;
using App.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_mvc_ads.Controllers
{
    public class AuthController : Controller
    {
        private readonly IService<User> _userService;

        public AuthController(IService<User> userService)
        {
            _userService = userService;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid && user is not null)
            {
                _userService.Add(user);
                _userService.SaveChanges();
                return RedirectToAction(nameof(Login));
            }
            else
            {
                ModelState.AddModelError("", "Bilgilerinizi kontrol ediniz");
                return View(user);
            }
            
        }
        public IActionResult Login(string redirectUrl)
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }

        public IActionResult TermsCondition()
        {
            return View();
        }
    }
}
