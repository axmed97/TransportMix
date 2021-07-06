using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

    public class AutoSalonController : Controller
    {
        private readonly Context _context;
        private readonly IWebHostEnvironment _env;

        public AutoSalonController(Context context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index(int pageNumber = 1)
        {
            return View(await _context.AutoSalons.OrderByDescending(x=>x.Id).ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AutoSalon autoSalon)
        {
            if (!ModelState.IsValid)
            {
                return View(autoSalon);
            }
            if (autoSalon.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please, select any image!");
                return View(autoSalon);
            }
            if (!autoSalon.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Image is not valid!");
                return View(autoSalon);
            }

            autoSalon.Image = await autoSalon.Photo.SaveFileAsync(_env.WebRootPath);
            await _context.AutoSalons.AddAsync(autoSalon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) NotFound();
            AutoSalon autoSalon = await _context.AutoSalons.FindAsync(id);
            if (autoSalon == null) NotFound();
            return View(autoSalon);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) NotFound();
            AutoSalon autoSalon = await _context.AutoSalons.FindAsync(id);
            if (autoSalon == null) NotFound();
            return View(autoSalon);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) NotFound();
            AutoSalon autoSalon = await _context.AutoSalons.FindAsync(id);
            if (autoSalon == null) NotFound();
                string path = _env.WebRootPath + @"\image\" + autoSalon.Image;
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                _context.AutoSalons.Remove(autoSalon);
                await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) NotFound();
            AutoSalon autoSalon = await _context.AutoSalons.FindAsync(id);
            if (autoSalon == null) NotFound();
            return View(autoSalon);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, AutoSalon autoSalon)
        {
            if (!ModelState.IsValid)
            {
                return View(autoSalon);
            }
            AutoSalon autoSalondb = await _context.AutoSalons.FindAsync(id);
            if (autoSalon.Photo != null)
            {
                if (autoSalon.Photo.ContentType.Contains("image/"))
                {
                    string path = _env.WebRootPath + @"\image\" + autoSalondb.Image;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    autoSalondb.Image = await autoSalon.Photo.SaveFileAsync(_env.WebRootPath);
                }
                else
                {
                    ModelState.AddModelError("Photo", "Selected image is not valid!");
                    return View(autoSalon);
                }
            }
            autoSalondb.SalonName = autoSalon.SalonName;
            autoSalondb.Phone = autoSalon.Phone;
            autoSalondb.SecondaryPhone = autoSalon.SecondaryPhone;
            autoSalondb.Email = autoSalon.Email;
            autoSalondb.Address = autoSalon.Address;
            autoSalondb.Facebook = autoSalon.Facebook;
            autoSalondb.Instagram = autoSalon.Instagram;
            autoSalondb.Youtube = autoSalon.Youtube;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
