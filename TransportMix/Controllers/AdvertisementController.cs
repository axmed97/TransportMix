using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportMix.Data;
using TransportMix.Models;
using TransportMix.ViewModel;

namespace TransportMix.Controllers
{
    public class AdvertisementController : Controller
    {
        private readonly Context _context;

        public AdvertisementController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AutoSalon()
        {
            var autoSalons = _context.AutoSalons.OrderByDescending(x => x.Id).Take(9).ToList();
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                AutoSalons = autoSalons
            };
            return View(homeViewModel);
        }
        public IActionResult Insurance()
        {
            var insurances = _context.Insurances.OrderByDescending(x => x.Id).Take(9).ToList();
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                Insurances = insurances
            };
            return View(homeViewModel);
        }
        public IActionResult Rent()
        {
            var rents = _context.Rents.OrderByDescending(x => x.Id).Take(9).ToList();
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                Rents = rents
            };
            return View(homeViewModel);
        }
        public IActionResult Transport()
        {
            var transport = _context.Transports.OrderByDescending(x => x.Id).Take(9).ToList();
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                Transports = transport
            };
            return View(homeViewModel);
        }
        public IActionResult AutoService()
        {
            var autoService = _context.AutoServices.OrderByDescending(x => x.Id).Take(9).ToList();
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                AutoServices = autoService
            };
            return View(homeViewModel);
        }
        public IActionResult Master()
        {
            var master = _context.Masters.OrderByDescending(x => x.Id).Take(9).ToList();
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                Masters = master
            };
            return View(homeViewModel);
        }
    }
}
