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

    public class AutoServiceController : Controller
    {
        private readonly Context _context;
        private readonly IWebHostEnvironment _env;

        public AutoServiceController(Context context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index(int pageNumber = 1)
        {
            var autoService = _context.AutoServices.OrderByDescending(x => x.Id).ToList();
            return View(autoService);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AutoService autoService)
        {
            if (!ModelState.IsValid)
            {
                return View(autoService);
            }
            if (autoService.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please, select any image!");
                return View(autoService);
            }
            if (!autoService.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Image is not valid!");
                return View(autoService);
            }

            autoService.Image = await autoService.Photo.SaveFileAsync(_env.WebRootPath);
            await _context.AutoServices.AddAsync(autoService);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) NotFound();
            AutoService autoService = await _context.AutoServices.FindAsync(id);
            if (autoService == null) NotFound();
            return View(autoService);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) NotFound();
            AutoService autoService = await _context.AutoServices.FindAsync(id);
            if (autoService == null) NotFound();
            return View(autoService);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) NotFound();
            AutoService autoService = await _context.AutoServices.FindAsync(id);
            if (autoService == null) NotFound();
            string path = _env.WebRootPath + @"\image\" + autoService.Image;
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _context.AutoServices.Remove(autoService);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) NotFound();
            AutoService autoService = await _context.AutoServices.FindAsync(id);
            if (autoService == null) NotFound();
            return View(autoService);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, AutoService autoService)
        {
            if (!ModelState.IsValid)
            {
                return View(autoService);
            }
            AutoService autoServicedb = await _context.AutoServices.FindAsync(id);
            if (autoService.Photo != null)
            {
                if (autoService.Photo.ContentType.Contains("image/"))
                {
                    string path = _env.WebRootPath + @"\image\" + autoServicedb.Image;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    autoServicedb.Image = await autoService.Photo.SaveFileAsync(_env.WebRootPath);
                }
                else
                {
                    ModelState.AddModelError("Photo", "Selected image is not valid!");
                    return View(autoService);
                }
            }
            autoServicedb.CompanyName = autoService.CompanyName;
            autoServicedb.Phone = autoService.Phone;
            autoServicedb.SecondaryPhone = autoService.SecondaryPhone;
            autoServicedb.Email = autoService.Email;
            autoServicedb.Address = autoService.Address;
            autoServicedb.Description = autoService.Description;
            autoServicedb.Facebook = autoService.Facebook;
            autoServicedb.Instagram = autoService.Instagram;
            autoServicedb.Youtube = autoService.Youtube;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
