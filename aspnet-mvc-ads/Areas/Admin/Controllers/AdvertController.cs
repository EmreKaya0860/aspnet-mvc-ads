using App.Data.Entity;
using App.Service.Abstract;
using aspnet_mvc_ads.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace aspnet_mvc_ads.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Policy = "AdminPolicy")]
    public class AdvertController : Controller
    {
        private readonly IService<Advert> _service;
        private readonly IService<User> _serviceUser;
        private readonly IService<AdvertComment> _serviceComment;
        private readonly IService<AdvertImage> _serviceImage;


        public AdvertController(IService<Advert> service, IService<User> uservice, IService<AdvertComment> serviceComment, IService<AdvertImage> serviceImage)
        {
            _service = service;
            _serviceUser = uservice;
            _serviceComment = serviceComment;
            _serviceImage = serviceImage;
        }

        public ActionResult Index()
        {

            var model = _service.GetAll();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public async Task<ActionResult> Create()
        {
            ViewBag.UserId = new SelectList(await _serviceUser.GetAllAsync(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(Advert advert)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _service.AddAsync(advert);
                    await _service.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }

            }
            return View(advert);
        }

        public async Task<ActionResult> EditAsync(int id)
        {
            var model = await _service.FindAsync(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(int id, Advert advert)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _service.Update(advert);
                    await _service.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            return View(advert);
        }

        public async Task<ActionResult> DeleteAsync(int id)
        {
            var model = await _service.FindAsync(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Advert advert)
        {
            try
            {
                _service.Delete(advert);
                _service.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> CommentListAsync(int id)
        {

            var comments =await  _serviceComment.GetAllAsync(a=> a.AdvertId == id);
            return View(comments);
        }

        public async Task<ActionResult> DeleteCommentAsync(int id)
        {
            var model = await _serviceComment.FindAsync(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteComment(int id, AdvertComment comment)
        {
            try
            {
                _serviceComment.Delete(comment);
                _serviceComment.SaveChanges();
                return RedirectToAction(nameof(CommentListAsync));
            }
            catch
            {
                return View();
            }
        }


        public async Task<ActionResult> ImageList(int id)
        {

           
            var model = await _serviceImage.GetAllAsync(a=> a.AdvertId==id);
            return View(model);
        }
        public async Task<ActionResult> CreateImageAsync()
        {
            ViewBag.AdvertId = new SelectList(await _service.GetAllAsync(), "Id", "Title"); 
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateImageAsync(int id, AdvertImage advertImage,IFormFile? ImagePath)
        {
          if (ModelState.IsValid)
          {
              try
              {
                   if (ImagePath is not null) advertImage.ImagePath = await FileHelper.FileLoaderAsync(ImagePath, "/wwwroot/images/AdvertImages/");
                   await _serviceImage.AddAsync(advertImage);
                   await _serviceImage.SaveChangesAsync();
                   return RedirectToAction(nameof(ImageList));
               }
                catch
               {
                   ModelState.AddModelError("", "Hata Oluştu!");
               }
           }
            ViewBag.AdvertId = new SelectList(await _service.GetAllAsync(), "Id", "Name"); 
            return View();
        }

        public async Task<ActionResult> EditImageAsync(int id)
        {
            var model = await _serviceImage.FindAsync(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditImageAsync(int id, AdvertImage image)
        {
          
            return View(image);
        }

        public async Task<ActionResult> DeleteImageAsync(int id)
        {
            var model = await _serviceImage.FindAsync(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteImage(int id, AdvertImage image)
        {
            try
            {
                _serviceImage.Delete(image);
                _serviceImage.SaveChanges();
                return RedirectToAction(nameof(ImageList));
            }
            catch
            {
                return View();
            }
        }

    }
}
