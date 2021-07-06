using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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


    public class ArticleController : Controller
    {
        private readonly Context _context;
        private readonly IWebHostEnvironment _env;

        public ArticleController(Context context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index(int pageNumber = 1)
        {
            var articles = _context.Articles.OrderByDescending(x => x.Id).ToList();
            return View(articles);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Articles articles)
        {
            if (!ModelState.IsValid)
            {
                return View(articles);
            }
            if (articles.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please, select any image!");
                return View(articles);
            }
            if (!articles.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Image is not valid!");
                return View(articles);
            }

            articles.Image = await articles.Photo.SaveFileAsync(_env.WebRootPath);
            articles.PublishDate = DateTime.Now;
            await _context.Articles.AddAsync(articles);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) NotFound();
            Articles articles = await _context.Articles.FindAsync(id);
            if (articles == null) NotFound();
            return View(articles);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) NotFound();
            Articles articles = await _context.Articles.FindAsync(id);
            if (articles == null) NotFound();
            return View(articles);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) NotFound();
            Articles articles = await _context.Articles.FindAsync(id);
            if (articles == null) NotFound();
            if (_context.News.ToList().Count > 1)
            {
                string path = _env.WebRootPath + @"\image\" + articles.Image;
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                _context.Articles.Remove(articles);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) NotFound();
            Articles articles = await _context.Articles.FindAsync(id);
            if (articles == null) NotFound();
            return View(articles);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Articles articles)
        {
            if (!ModelState.IsValid)
            {
                return View(articles);
            }
            Articles articlesdb = await _context.Articles.FindAsync(id);
            if (articles.Photo != null)
            {
                if (articles.Photo.ContentType.Contains("image/"))
                {
                    string path = _env.WebRootPath + @"\image\" + articlesdb.Image;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    articlesdb.Image = await articles.Photo.SaveFileAsync(_env.WebRootPath);
                }
                else
                {
                    ModelState.AddModelError("Photo", "Selected image is not valid!");
                    return View(articles);
                }
            }
            articlesdb.Header = articles.Header;
            articlesdb.Content = articles.Content;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
