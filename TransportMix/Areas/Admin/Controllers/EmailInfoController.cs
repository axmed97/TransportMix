using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportMix.Data;
using TransportMix.Models;

namespace TransportMix.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    [Authorize(Roles = "Admin")]
    public class EmailInfoController : Controller
    {
        private readonly Context _context;

        public EmailInfoController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var email = _context.Emailnfos.First();
            return View(email);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) NotFound();
            Emailnfos emailnfos = await _context.Emailnfos.FindAsync(id);
            if (emailnfos == null) NotFound();
            return View(emailnfos);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Emailnfos emailnfos)
        {
            if (!ModelState.IsValid)
            {
                return View(emailnfos);
            }
            Emailnfos emailnfosdb = await _context.Emailnfos.FindAsync(id);
            
            emailnfosdb.Email = emailnfos.Email;
            emailnfosdb.Password = emailnfos.Password;
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
