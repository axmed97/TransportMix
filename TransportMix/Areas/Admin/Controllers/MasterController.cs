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
    public class MasterController : Controller
    {
        private readonly Context _context;
        private readonly IWebHostEnvironment _env;

        public MasterController(Context context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index(int pageNumber = 1)
        {
            var master = await _context.Masters.OrderByDescending(x => x.Id).ToListAsync();
            return View(master);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Master master)
        {
            if (!ModelState.IsValid)
            {
                return View(master);
            }
            if (master.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please, select any image!");
                return View(master);
            }
            if (!master.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Image is not valid!");
                return View(master);
            }

            master.Image = await master.Photo.SaveFileAsync(_env.WebRootPath);
            await _context.Masters.AddAsync(master);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) NotFound();
            Master master = await _context.Masters.FindAsync(id);
            if (master == null) NotFound();
            return View(master);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) NotFound();
            Master master = await _context.Masters.FindAsync(id);
            if (master == null) NotFound();
            return View(master);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) NotFound();
            Master master = await _context.Masters.FindAsync(id);
            if (master == null) NotFound();
            string path = _env.WebRootPath + @"\image\" + master.Image;
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _context.Masters.Remove(master);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) NotFound();
            Master master = await _context.Masters.FindAsync(id);
            if (master == null) NotFound();
            return View(master);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Master master)
        {
            if (!ModelState.IsValid)
            {
                return View(master);
            }
            Master masterdb = await _context.Masters.FindAsync(id);
            if (master.Photo != null)
            {
                if (master.Photo.ContentType.Contains("image/"))
                {
                    string path = _env.WebRootPath + @"\image\" + masterdb.Image;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    masterdb.Image = await master.Photo.SaveFileAsync(_env.WebRootPath);
                }
                else
                {
                    ModelState.AddModelError("Photo", "Selected image is not valid!");
                    return View(master);
                }
            }
            masterdb.MasterName = master.MasterName;
            masterdb.Phone = master.Phone;
            masterdb.SecondaryPhone = master.SecondaryPhone;
            masterdb.Email = master.Email;
            masterdb.Address = master.Address;
            masterdb.Description = master.Description;
            masterdb.Facebook = master.Facebook;
            masterdb.Instagram = master.Instagram;
            masterdb.Youtube = master.Youtube;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
