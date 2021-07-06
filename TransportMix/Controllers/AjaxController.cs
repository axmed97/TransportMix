using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportMix.Data;
using TransportMix.ViewModel;

namespace TransportMix.Controllers
{
    public class AjaxController : Controller
    {
        private readonly Context _context;

        public AjaxController(Context context)
        {
            _context = context;
        }

        public IActionResult LoadMoreNews(int skipCount)
        {
            var news = _context.News.OrderByDescending(x => x.Id).Skip(skipCount).Take(1).ToList();
            return PartialView("_NewsPartial", new NewsVM { newlar = news});
        }
        public IActionResult LoadMoreArticle(int skipCount)
        {
            var article = _context.Articles.OrderByDescending(x => x.Id).Skip(skipCount).Take(1).ToList();
            return PartialView("_ArticlePartial", new ArticleVM { Articles = article });
        }

        public IActionResult LoadMoreAutoSalon(int skipCount)
        {
            var autoSalon = _context.AutoSalons.OrderByDescending(x => x.Id).Skip(skipCount).Take(3).ToList();
            return PartialView("_AutoSalonPartial", new AutoSalonVM {AutoSalons = autoSalon });
        }

        public IActionResult LoadMoreInsurance(int skipCount)
        {
            var insurance = _context.Insurances.OrderByDescending(x => x.Id).Skip(skipCount).Take(3).ToList();
            return PartialView("_InsurancePartial", new InsuranceVM { Insurances = insurance });
        }
        public IActionResult LoadMoreService(int skipCount)
        {
            var autoServices = _context.AutoServices.OrderByDescending(x => x.Id).Skip(skipCount).Take(3).ToList();
            return PartialView("_AutoServicePartial", new AutoServiceVM { AutoServices = autoServices });
        }
        public IActionResult LoadMoreMaster(int skipCount)
        {
            var masters = _context.Masters.OrderByDescending(x => x.Id).Skip(skipCount).Take(3).ToList();
            return PartialView("_MasterPartial", new MasterVM { Masters = masters });
        }
        public IActionResult LoadMoreRent(int skipCount)
        {
            var rents = _context.Rents.OrderByDescending(x => x.Id).Skip(skipCount).Take(3).ToList();
            return PartialView("_RentPartial", new RentVM { Rents = rents });
        }

        public IActionResult LoadMoreTransport(int skipCount)
        {
            var transports = _context.Transports.OrderByDescending(x => x.Id).Skip(skipCount).Take(3).ToList();
            return PartialView("_TransportPartial", new TransportVM { Transports = transports });
        }

    }
}
