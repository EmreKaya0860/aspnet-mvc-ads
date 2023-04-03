using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using App.Service.Abstract;
using App.Data.Entity;

namespace aspnet_mvc_ads.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly IService<User>  _userService;

        public LoginController(IService<User> userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string email, string password)
        {
            var user = _userService.Get(u => u.Email == email && u.Password == password);
            
            if (user is not null)
            {
                var userClaims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim("Role", user.IsAdmin ? "Admin" : "User"),
                    new Claim("UserId", user.Id.ToString())
                };
               
                var userAuth = new ClaimsIdentity(userClaims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new(userAuth);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Main");
            }
            else
            {
                TempData["HataMesajı"] = "Bilgilerinizi kontrol edin!";
            }

            return View();
        }

        [Route("/Admin/Logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/Admin/Login");
        }

    }
}
