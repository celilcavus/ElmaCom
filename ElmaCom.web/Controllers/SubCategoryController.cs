using ElmaCom.BusinessLayer.Interfaces;
using ElmaCom.Entity.Entites;
using Microsoft.AspNetCore.Mvc;

namespace ElmaCom.web.Controllers
{
    public class SubCategoryController : Controller
    {
        private IRepositoryManager _manager;

        public SubCategoryController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index([FromForm] SubCategory category)
        {
            _manager.SubCategoryRepository.Add(category);
            _manager.SubCategoryRepository.Save();
            return View();
        }

        [HttpGet]
        public IActionResult GetSubCategoryList()
        {
            var model = _manager.SubCategoryRepository.GetAll();
            return View(model);
        }

        [HttpGet]
        public IActionResult Update([FromRoute] int id)
        {
            int? _id = id;
            if (_id.HasValue && _id.Value > 0)
            {
                var FindModel = _manager.SubCategoryRepository.GetById(id);
                return View(FindModel);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Update([FromForm] SubCategory subCategory, [FromRoute] int id)
        {
            int? _id = id;
            if (_id.HasValue && _id.Value > 0)
            {
                var FindModel = _manager.SubCategoryRepository.GetById(id);
                FindModel.SubCategoryName = subCategory.SubCategoryName;
                FindModel.BaseCategoryId = subCategory.BaseCategoryId;
                FindModel.Description = subCategory.Description;
                FindModel.IsActive = subCategory.IsActive;
                FindModel.CreateDate = subCategory.CreateDate;
                FindModel.LastUpdateDate = DateTime.Now;
                _manager.SubCategoryRepository.Save();

                return RedirectToAction(nameof(GetSubCategoryList));
            }
            return RedirectToAction(nameof(GetSubCategoryList));
        }


        [HttpGet]
        public IActionResult Delete([FromRoute] int id)
        {
            int? _id = id;
            if (_id.HasValue && _id.Value > 0)
            {
                var FindModel = _manager.SubCategoryRepository.GetById(id);

                _manager.SubCategoryRepository.Delete(FindModel);
                _manager.SubCategoryRepository.Save();

                return RedirectToAction(nameof(GetSubCategoryList));
            }
            return RedirectToAction(nameof(GetSubCategoryList));
        }


    }
}
