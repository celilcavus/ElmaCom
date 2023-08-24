using ElmaCom.BusinessLayer.Interfaces;
using ElmaCom.Entity.Entites;
using ElmaCom.web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ElmaCom.web.Controllers
{
    public class HomeController : Controller
    {
      
        private IBaseCategoryRepository _baseCategory;

        public HomeController(IBaseCategoryRepository baseCategory)
        {
            _baseCategory = baseCategory;
        }

       
        public IActionResult Index()
        {
            var model = _baseCategory.GetAll();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}