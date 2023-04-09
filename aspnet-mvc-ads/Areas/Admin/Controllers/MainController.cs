using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_mvc_ads.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MainController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
