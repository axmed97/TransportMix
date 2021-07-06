using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using TransportMix.Data;
using TransportMix.Models;
using TransportMix.ViewModel;

namespace TransportMix.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context;

        public HomeController(ILogger<HomeController> logger, Context context = null)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List <News> news = _context.News.OrderByDescending(x => x.Id).ToList();
            HomeViewModel homeViewModel = new()
            {
                News = news
            };
            return View(homeViewModel);
        }

        public IActionResult DetailNews(int? id)
        {
            if (id == null) NotFound();
            News news = _context.News.FirstOrDefault(x => x.Id == id);
            if (news == null) NotFound();
            return View(news);
        }

        public IActionResult DetailArticle(int? id)
        {
            if (id == null) NotFound();
            Articles articles = _context.Articles.FirstOrDefault(x => x.Id == id);
            if (articles == null) NotFound();
            return View(articles);
        }

        public IActionResult Article()
        {
            List<Articles> articles = _context.Articles.OrderByDescending(x => x.Id).ToList();
            List<News> news = _context.News.OrderByDescending(x => x.Id).ToList();
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                News = news,
                Articles = articles
            };
            return View(homeViewModel);
        }

        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Contact(ContactVM contactVM)
        {
            var emailInfo = _context.Emailnfos.First();

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(emailInfo.Email, "TransportMix.az");
            mailMessage.To.Add(new MailAddress(emailInfo.Email));
            mailMessage.Subject = contactVM.Subject;
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = "Name: " + contactVM.Name + "; Email: " + contactVM.Email + "; Messages: " + contactVM.Content;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(emailInfo.Email, emailInfo.Password);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            await smtpClient.SendMailAsync(mailMessage);
            return RedirectToAction("Contact");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
