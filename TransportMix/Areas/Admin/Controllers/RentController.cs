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

    public class RentController : Controller
    {
        private readonly Context _context;
        private readonly IWebHostEnvironment _env;
        public RentController(Context context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index(int pageNumber = 1)
        {
            var rents = await _context.Rents.OrderByDescending(x => x.Id).ToListAsync();
            return View(rents);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Rent rent)
        {
            if (!ModelState.IsValid)
            {
                return View(rent);
            }
            if (rent.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please, select any image!");
                return View(rent);
            }
            if (!rent.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Image is not valid!");
                return View(rent);
            }

            rent.Image = await rent.Photo.SaveFileAsync(_env.WebRootPath);
            await _context.Rents.AddAsync(rent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) NotFound();
            Rent rent = await _context.Rents.FindAsync(id);
            if (rent == null) NotFound();
            return View(rent);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) NotFound();
            Rent rent = await _context.Rents.FindAsync(id);
            if (rent == null) NotFound();
            return View(rent);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) NotFound();
            Rent rent = await _context.Rents.FindAsync(id);
            if (rent == null) NotFound();
            string path = _env.WebRootPath + @"\image\" + rent.Image;
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _context.Rents.Remove(rent);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) NotFound();
            Rent rent = await _context.Rents.FindAsync(id);
            if (rent == null) NotFound();
            return View(rent);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Rent rent)
        {
            if (!ModelState.IsValid)
            {
                return View(rent);
            }
            Rent rentdb = await _context.Rents.FindAsync(id);
            if (rent.Photo != null)
            {
                if (rent.Photo.ContentType.Contains("image/"))
                {
                    string path = _env.WebRootPath + @"\image\" + rentdb.Image;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    rentdb.Image = await rent.Photo.SaveFileAsync(_env.WebRootPath);
                }
                else
                {
                    ModelState.AddModelError("Photo", "Selected image is not valid!");
                    return View(rent);
                }
            }
            rentdb.CompanyName = rent.CompanyName;
            rentdb.Phone = rent.Phone;
            rentdb.SecondaryPhone = rent.SecondaryPhone;
            rentdb.Email = rent.Email;
            rentdb.Address = rent.Address;
            rentdb.Facebook = rent.Facebook;
            rentdb.Instagram = rent.Instagram;
            rentdb.Youtube = rent.Youtube;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
