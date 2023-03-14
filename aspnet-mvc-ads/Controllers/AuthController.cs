using App.Data.Entity;
using App.Service.Abstract;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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

        [Route("/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("/Login")]
        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var user = _userService.Get(u => u.Email == email && u.Password == password);

            
            if (user is not null)
            {
                var userClaims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.Role, "User"),
                    new Claim("UserId", user.Id.ToString())
                };
				Response.Cookies.Append("userguid", Guid.NewGuid().ToString());
                Response.Cookies.Append("userName", user.Name);
                Response.Cookies.Append("userPhone", user.Phone);
                Response.Cookies.Append("userEmail", user.Email);
                Response.Cookies.Append("userAdress", user.Address);



                var userAuth = new ClaimsIdentity(userClaims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new(userAuth);
                await HttpContext.SignInAsync(principal);

                
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["HataMesajı"] = "Bilgilerinizi kontrol edin!";
            }

            return View();
        }

        [Route("/Logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
			Response.Cookies.Delete("userguid");
            Response.Cookies.Delete("userName");
            Response.Cookies.Delete("userPhone");
            Response.Cookies.Delete("userEmail");
            Response.Cookies.Delete("userAdress");
            return Redirect("/Login");
        }
    
       

    }
}
