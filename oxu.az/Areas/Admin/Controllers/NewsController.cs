using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using oxuAz.Abstractions;
using oxuAz.Models;

namespace oxuAz.Areas.Admin.Controllers
{
        [Area("Admin")]
        [Route("admin/[controller]/[action]")]
    public class NewsController : Controller
    {
        private readonly INewsRepo _newsRepo;
        private readonly IWebHostEnvironment _webhost;
        public NewsController(INewsRepo newsRepo, IWebHostEnvironment webHost)
        {
            _newsRepo = newsRepo;
            _webhost = webHost;
        }
        public IActionResult Index()
        {
            return View(_newsRepo.GetAllNews());
        }
        private void SaveImage(News news)
        {
            var date = DateTime.Now.ToString("MM-dd-yyyy,hh-mm-ss-tt");
            var fileName = Path.GetFileNameWithoutExtension(news.File.FileName);
            var fileExtension = Path.GetExtension(news.File.FileName);

            var fileFullName = $"{fileName}-{date}{fileExtension}";
            var rootPath = Path.Combine(_webhost.WebRootPath, "NewsAsserts", fileFullName);
            news.FileName = fileFullName;
            using (var fileStream = new FileStream(rootPath, FileMode.Create))
            {
                news.File.CopyTo(fileStream);
            }
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(News news)
        {
            if (ModelState.IsValid)
            {
                SaveImage(news);
                _newsRepo.Add(news);
                return RedirectToAction("Index");
            }
            return View(news);
        }
        public IActionResult Edit(int id)
        {
            News news = _newsRepo.GetNewsById(id);
            if (news != null)
            {
                return View(news);
            }
            return StatusCode(400);
        }
        [HttpPost]
        public IActionResult Edit(News news)
        {
            if (ModelState.IsValid)
            {
                News news_ = _newsRepo.GetNewsById(news.Id);
                if (news_ != null)
                {
                    if (news.File != null)
                    {
                        SaveImage(news);
                    }
                    _newsRepo.Edit(news);
                    return RedirectToAction("Index");
                }
            }
            return View(news);
        }
        public IActionResult Delete(int id)
        {
            News news = _newsRepo.GetNewsById(id);
            if (news != null)
            {
                return View(news);
            }
            return StatusCode(400);
        }
        [HttpPost]
        public IActionResult Delete(News news)
        {
            if (news != null)
            {
                _newsRepo.Delete(news);
                return RedirectToAction("Index");
            }
            return StatusCode(400);
        }
    }
}
