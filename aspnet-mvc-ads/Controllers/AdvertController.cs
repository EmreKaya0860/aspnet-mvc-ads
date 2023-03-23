using App.Data.Entity;
using App.Service.Abstract;
using App.Service.Concrete;
using aspnet_mvc_ads.Models;
using aspnet_mvc_ads.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;


namespace aspnet_mvc_ads.Controllers
{
	public class AdvertController : Controller
	{
		public readonly ICategoryAdvertService _categoryAdvertService;
		public readonly IService<Category> _CategoryService;
		public readonly IAdvertService _advertService;
		public readonly IService<User> _UserService;
		public readonly IAdvertListingService _AdvertListingService;
        private readonly IService<AdvertComment> _serviceComment;
        private readonly IService<Advert> _serviceAdvert;


        public AdvertController(ICategoryAdvertService categoryAdvertService, IService<Category> categoryService, IAdvertService advertService, IService<User> userService, IAdvertListingService advertListingService, IService<AdvertComment> serviceComment, IService<Advert> serviceAdvert)
        {
            _categoryAdvertService = categoryAdvertService;
            _CategoryService = categoryService;
            _advertService = advertService;
            _UserService = userService;
            _AdvertListingService = advertListingService;
            _serviceComment = serviceComment;
            _serviceAdvert = serviceAdvert;
        }

        public async Task<IActionResult> Search(int CategoryId, string query = "")
		{
			var model = await _categoryAdvertService.GetAllAdvertsByCategory(CategoryId, query);

			ViewData["AllCategories"] = _CategoryService.GetAll();

			return View(model);

		}


		public IActionResult AddListing()
		{
			ViewData["Categories"] = _CategoryService.GetAll();
            ViewData["userName"] = Request.Cookies["userName"];
            ViewData["userPhone"] = Request.Cookies["userPhone"];
            ViewData["userEmail"] = Request.Cookies["userEmail"];
            ViewData["userAdress"] = Request.Cookies["userAdress"];
            return View();
		}


		[HttpPost]
        public async Task<IActionResult> AddListing(int categoryId, AddListingViewModel addListingView, List<IFormFile>? Images)
        {
            ViewData["Categories"] = _CategoryService.GetAll();
            ViewData["userName"] = Request.Cookies["userName"];
            ViewData["userPhone"] = Request.Cookies["userPhone"];
            ViewData["userEmail"] = Request.Cookies["userEmail"];
            ViewData["userAdress"] = Request.Cookies["userAdress"];


            var user = _UserService.Get(a => a.Email == Request.Cookies["userEmail"]);
            var category = _CategoryService.GetAll(c => c.Id == categoryId);

            List<AdvertImage> advertImages = new List<AdvertImage>();

            foreach (IFormFile item in Images)
            {
                AdvertImage advertImage = new AdvertImage();

                advertImage.ImagePath = await FileHelper.FileLoaderAsync(item, filePath: "/wwwroot/images/");

                advertImages.Add(advertImage);

            }

            _AdvertListingService.AddList(user, addListingView.Advert, advertImages, category);


            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Detail(int? id)

		{
            //var advert = await _categoryAdvertService.                 _service.GetProductByCategoriesBrandsAsync(id);
            //await _advertService.ClickUpdating(id);
            if (id is not null)
            {
                var advert = await _advertService.FindAsync(id.Value);
                ViewData["userName"] = Request.Cookies["userName"];
                ViewData["userEmail"] = Request.Cookies["userEmail"];
                return View(advert);
            }
            else
            {
                return BadRequest();
            }
		}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(string review, int id)
        {
            var advert = await _serviceAdvert.FindAsync(id);
            var user = await _UserService.FirstOrDefaultAsync(u => u.Email == Request.Cookies["userEmail"]);

            AdvertComment advertComment = new AdvertComment();
            advertComment.Advert = advert;
            advertComment.user = user;
            advertComment.Comment = review;
            _serviceComment.Add(advertComment);
            _serviceComment.SaveChanges();
            return RedirectToAction("Detail",new {id = advert.Id});

        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(AdvertComment advertcommet)
        //{
        //    _serviceComment.Add(advertcommet);
        //    _serviceComment.SaveChanges();
        //    return RedirectToAction("Detail");

        //}


    }
}
