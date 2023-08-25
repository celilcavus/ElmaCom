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
        public IActionResult Index([FromForm] BaseCategory baseCategory)
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

        public IActionResult Delete([FromRoute] int id)
        {
            int? _id = id;
            if (_id.HasValue && _id.Value > 0)
            {
                BaseCategory? findModel = _category.GetById(_id.Value);
                if (findModel != null)
                {
                    _category.Delete(findModel);
                    _category.Save();
                }
                else
                    return RedirectToAction(nameof(GetList));

            }
            return RedirectToAction(nameof(GetList));
        }

        [HttpGet]
        public IActionResult Update([FromRoute] int id)
        {
            int? _id = id;
            if (_id.HasValue && _id.Value > 0)
            {
                BaseCategory? findModel = _category.GetById(_id.Value);
                if (findModel != null)
                {
                    return View(findModel);
                }
                else
                    return RedirectToAction(nameof(GetList));

            }
            return RedirectToAction(nameof(GetList));
        }


        public IActionResult Update([FromForm] BaseCategory category, [FromRoute] int id)
        {
            int? _id = id;
            if (_id.HasValue && _id.Value > 0)
            {
                BaseCategory? findModel = _category.GetById(_id.Value);
                if (findModel != null)
                {
                    findModel.CategoryName = category.CategoryName;
                    findModel.Description = category.Description;
                    findModel.IsActive = category.IsActive;
                    findModel.LastUpdateDate = DateTime.Now;

                    _category.Save();
                    return RedirectToAction(nameof(GetList));
                }
                else
                    return RedirectToAction(nameof(Update));

            }
            return RedirectToAction(nameof(GetList));
        }

    }
}
