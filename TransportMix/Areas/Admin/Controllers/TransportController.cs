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

    public class TransportController : Controller
    {
        private readonly Context _context;
        private readonly IWebHostEnvironment _env;

        public TransportController(Context context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index(int pageNumber = 1)
        {
            var transport = await _context.Transports.OrderByDescending(x => x.Id).ToListAsync();
            return View(transport);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Transport transport)
        {
            if (!ModelState.IsValid)
            {
                return View(transport);
            }
            if (transport.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please, select any image!");
                return View(transport);
            }
            if (!transport.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Image is not valid!");
                return View(transport);
            }

            transport.Image = await transport.Photo.SaveFileAsync(_env.WebRootPath);
            await _context.Transports.AddAsync(transport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) NotFound();
            Transport transport = await _context.Transports.FindAsync(id);
            if (transport == null) NotFound();
            return View(transport);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) NotFound();
            Transport transport = await _context.Transports.FindAsync(id);
            if (transport == null) NotFound();
            return View(transport);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) NotFound();
            Transport transport = await _context.Transports.FindAsync(id);
            if (transport == null) NotFound();
            string path = _env.WebRootPath + @"\image\" + transport.Image;
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _context.Transports.Remove(transport);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) NotFound();
            Transport transport = await _context.Transports.FindAsync(id);
            if (transport == null) NotFound();
            return View(transport);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Transport transport)
        {
            if (!ModelState.IsValid)
            {
                return View(transport);
            }
            Transport transportdb = await _context.Transports.FindAsync(id);
            if (transport.Photo != null)
            {
                if (transport.Photo.ContentType.Contains("image/"))
                {
                    string path = _env.WebRootPath + @"\image\" + transportdb.Image;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    transportdb.Image = await transport.Photo.SaveFileAsync(_env.WebRootPath);
                }
                else
                {
                    ModelState.AddModelError("Photo", "Selected image is not valid!");
                    return View(transport);
                }
            }
            transportdb.CompanyName = transport.CompanyName;
            transportdb.Phone = transport.Phone;
            transportdb.SecondaryPhone = transport.SecondaryPhone;
            transportdb.Email = transport.Email;
            transportdb.Address = transport.Address;
            transportdb.Facebook = transport.Facebook;
            transportdb.Instagram = transport.Instagram;
            transportdb.Youtube = transport.Youtube;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
