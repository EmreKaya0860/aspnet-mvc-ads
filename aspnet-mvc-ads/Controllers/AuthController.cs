using App.Data.Entity;
using App.Service.Abstract;
using aspnet_mvc_ads.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Common;
using System.Security.Claims;

namespace aspnet_mvc_ads.Controllers
{
    public class AuthController : Controller
    {
        private readonly IService<User> _userService;
        readonly UserManager<User> _userManager;

        public AuthController(IService<User> userService, UserManager<User> userManager)
        {
            _userService = userService;
            _userManager = userManager;
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
        public IActionResult ResetPassword()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPasswordAsync(ResetPasswordModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user != null)
            {
                string resettoken = await _userManager.GeneratePasswordResetTokenAsync(user);

                string passwordresetlink = Url.Action("UpdatePassword", "User", new { userId = user.Id, token = resettoken },HttpContext.Request.Scheme);

                Utils.ResetPassword.PasswordSendMail(passwordresetlink);
                ViewBag.State = true;
            }

            else
            {
                ViewBag.State = false;
            }
            return View();
        }


        public IActionResult UpdatePassword(string userId,string token)
        {
            TempData["userId"] = userId;
            TempData["token"] = token;

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdatePasswordAsync([Bind("NewPassword")] ResetPasswordModel model)
        {
            string token = TempData["token"].ToString;
            string userId = TempData["userId"].ToString;

            var user = await _userManager.FindByIdAsync(userId);

            if (user != null)
            {
                IdentityResult result = await _userManager.ResetPasswordAsync(user, token, model.NewPassword);

                if (result.Succeeded)
                {
                    await _userManager.UpdateSecurityStampAsync(user);
                    TempData["Success"] = "Başarıyla güncellenmiştir";
                    
                }
            }

            else
            {
                ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı");
            }

            return View();
        }

    }
}
