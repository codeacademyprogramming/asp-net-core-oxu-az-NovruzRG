using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using oxuAz.Abstractions;
using oxuAz.Models;

namespace oxuAz.Controllers
{
    public class HomeController : Controller
    {
        private readonly INewsRepo _newsRepo;
        public HomeController(INewsRepo newsRepo)
        {
            _newsRepo = newsRepo;
        }
        public IActionResult Index()
        {
            return View(_newsRepo.GetAllNews());
        }
        [HttpPost]
        public JsonResult Like(int id)
        {
            if (_newsRepo.AddLike(id))
            {
                return Json(200);
            }
            return Json(400);
        }
        [HttpPost]
        public JsonResult Dislike(int id)
        {
            if (_newsRepo.AddDislike(id))
            {
                return Json(200);
            }
            return Json(400);
        }
        public IActionResult Details(int id)
        {
            News news = _newsRepo.GetNewsById(id);
            if (news != null)
            {
                if (_newsRepo.AddView(id))
                {
                    return View(news);
                }
            }
            return RedirectToAction("Home", "Error");
        }
    }
}
