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
    public class InsuranceController : Controller
    {
        private readonly Context _context;
        private readonly IWebHostEnvironment _env;
        public InsuranceController(Context context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index(int pageNumber = 1)
        {
            var insurances = await _context.Insurances.OrderByDescending(x => x.Id).ToListAsync();
            return View(insurances);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Insurance insurance)
        {
            if (!ModelState.IsValid)
            {
                return View(insurance);
            }
            if (insurance.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please, select any image!");
                return View(insurance);
            }
            if (!insurance.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Image is not valid!");
                return View(insurance);
            }

            insurance.Image = await insurance.Photo.SaveFileAsync(_env.WebRootPath);
            await _context.Insurances.AddAsync(insurance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) NotFound();
            Insurance insurance  = await _context.Insurances.FindAsync(id);
            if (insurance == null) NotFound();
            return View(insurance);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) NotFound();
            Insurance insurance = await _context.Insurances.FindAsync(id);
            if (insurance == null) NotFound();
            return View(insurance);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) NotFound();
            Insurance insurance = await _context.Insurances.FindAsync(id);
            if (insurance == null) NotFound();
            string path = _env.WebRootPath + @"\image\" + insurance.Image;
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _context.Insurances.Remove(insurance);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) NotFound();
            Insurance insurance = await _context.Insurances.FindAsync(id);
            if (insurance == null) NotFound();
            return View(insurance);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Insurance insurance)
        {
            if (!ModelState.IsValid)
            {
                return View(insurance);
            }
            Insurance insurancedb = await _context.Insurances.FindAsync(id);
            if (insurance.Photo != null)
            {
                if (insurance.Photo.ContentType.Contains("image/"))
                {
                    string path = _env.WebRootPath + @"\image\" + insurancedb.Image;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    insurancedb.Image = await insurance.Photo.SaveFileAsync(_env.WebRootPath);
                }
                else
                {
                    ModelState.AddModelError("Photo", "Selected image is not valid!");
                    return View(insurance);
                }
            }
            insurancedb.CompanyName = insurance.CompanyName;
            insurancedb.Phone = insurance.Phone;
            insurancedb.SecondaryPhone = insurance.SecondaryPhone;
            insurancedb.Email = insurance.Email;
            insurancedb.Address = insurance.Address;
            insurancedb.Facebook = insurance.Facebook;
            insurancedb.Instagram = insurance.Instagram;
            insurancedb.Youtube = insurance.Youtube;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
