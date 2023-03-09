using App.Data.Entity;
using App.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace aspnet_mvc_ads.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdvertController : Controller
    {
        private readonly IService<Advert> _service;
        private readonly IService<User> _serviceUser;
        private readonly IService<AdvertComment> _serviceComment;


        public AdvertController(IService<Advert> service, IService<User> uservice, IService<AdvertComment> serviceComment)
        {
            _service = service;
            _serviceUser = uservice;
            _serviceComment = serviceComment;
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

        public ActionResult CommentList()
        {

            var comments = _serviceComment.GetAll();
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
                return RedirectToAction(nameof(CommentList));
            }
            catch
            {
                return View();
            }
        }



    }
}
