using ElmaCom.BusinessLayer.Interfaces;
using ElmaCom.Entity.Entites;
using Microsoft.AspNetCore.Mvc;

namespace ElmaCom.web.Controllers
{
    public class BaseCategoryController : Controller
    {
        private IBaseCategoryRepository _category;

        public BaseCategoryController(IBaseCategoryRepository category)
        {
            _category = category;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index([FromForm]BaseCategory baseCategory)
        {
            _category.Add(baseCategory);
            _category.Save();
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult GetList()
        {
            var model = _category.GetAll();
            return View(model);
        }
    }
}
