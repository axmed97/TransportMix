using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TransportMix.Data;
using TransportMix.Helper;
using TransportMix.Helpers;
using TransportMix.Models;

namespace TransportMix.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    [Authorize(Roles = "Admin, Moderator")]

    public class NewsController : Controller
    {
        private readonly Context _context;
        private readonly IWebHostEnvironment _env;

        public NewsController(Context context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index(int pageNumber = 1)
        {
            var news = await _context.News.OrderByDescending(x => x.Id).ToListAsync();
            return View(news);
        }

        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(News news)
        {
            if (!ModelState.IsValid)
            {
                return View(news);
            }
            if (news.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please, select any image!");
                return View(news);
            }
            if (!news.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Image is not valid!");
                return View(news);
            }
            
            news.Image = await news.Photo.SaveFileAsync(_env.WebRootPath);
            news.PublishDate = DateTime.Now;
            await _context.News.AddAsync(news);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) NotFound();
            News news = await _context.News.FindAsync(id);
            if (news == null) NotFound();
            return View(news);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) NotFound();
            News news = await _context.News.FindAsync(id);
            if (news == null) NotFound();
            return View(news);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) NotFound();
            News news = await _context.News.FindAsync(id);
            if (news == null) NotFound();
            if (_context.News.ToList().Count > 1)
            {
                string path = _env.WebRootPath + @"\image\" + news.Image;
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                _context.News.Remove(news);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) NotFound();
            News news = await _context.News.FindAsync(id);
            if (news == null) NotFound();
            return View(news);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, News news)
        {
            if (!ModelState.IsValid)
            {
                return View(news);
            }
            News newsdb = await _context.News.FindAsync(id);
            if (news.Photo != null)
            {
                if (news.Photo.ContentType.Contains("image/"))
                {
                    string path = _env.WebRootPath + @"\image\" + newsdb.Image;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    newsdb.Image = await news.Photo.SaveFileAsync(_env.WebRootPath);
                }
                else
                {
                    ModelState.AddModelError("Photo", "Selected image is not valid!");
                    return View(news);
                }
            }
            newsdb.Name = news.Name;
            newsdb.Content = news.Content;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
