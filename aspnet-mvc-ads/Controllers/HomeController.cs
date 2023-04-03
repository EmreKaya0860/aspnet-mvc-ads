using App.Data.Entity;
using App.Service.Abstract;
using aspnet_mvc_ads.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace aspnet_mvc_ads.Controllers
{
	public class HomeController : Controller
    {
        private readonly IService<Category> _CategoryService;
        private readonly IService<User> _UserService;

		public HomeController(IService<Category> categoryService, IService<User> userService)
		{
			_CategoryService = categoryService;
			_UserService = userService;
		}

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View(_CategoryService.GetAll());
        }

        public IActionResult ErrorPage()
        {
            return View();
        }

        public IActionResult Package()
        {
            return View();
        }

        public IActionResult Store()
        {
            return View();
        }

		public IActionResult Post()
		{
			return View();
		}

        public IActionResult Blog()
        {
            return View();
        }

        public async Task<IActionResult> Profile()
        {
			var userGuid = Request.Cookies["userguid"];
            TempData["userGuid"] = userGuid;
            var user = await _UserService.FirstOrDefaultAsync(x => x.userGuid == userGuid);
			return View(user);
        }

        [HttpPost]
		public async Task<IActionResult> EditPersonalInfo(string name, string phone, string address)
		{
			var userGuid = Request.Cookies["userguid"];
			var user = await _UserService.FirstOrDefaultAsync(x => x.userGuid == userGuid);
			user.Name = name;
            user.Phone = phone;
            user.Address = address;
            _UserService.Update(user);
            _UserService.SaveChanges();
			return RedirectToAction("Profile", user);
		}

		[HttpPost]
		public async Task<IActionResult> EditPassword(string password)
		{
			var userGuid = Request.Cookies["userguid"];
			var user = await _UserService.FirstOrDefaultAsync(x => x.userGuid == userGuid);
			user.Password = password;
			_UserService.Update(user);
			_UserService.SaveChanges();
			return RedirectToAction("Profile", user);
		}

		[HttpPost]
		public async Task<IActionResult> EditEmail(string email)
		{
			var userGuid = Request.Cookies["userguid"];
			var user = await _UserService.FirstOrDefaultAsync(x => x.userGuid == userGuid);
			user.Email = email;
			_UserService.Update(user);
			_UserService.SaveChanges();
			return RedirectToAction("Profile", user);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("AccessDenied")]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}