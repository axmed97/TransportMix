using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using TransportMix.Data;
using TransportMix.Models;
using TransportMix.ViewModel;

namespace TransportMix.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly Context _context;

        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, Context context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View(registerVM);
            }
            AppUser appUser = new AppUser()
            {
                Email = registerVM.Email,
                UserName = registerVM.Username,
            };
            IdentityResult identityResult = await _userManager.CreateAsync(appUser, registerVM.Password);
            if (identityResult.Succeeded)
            {
                await _signInManager.SignInAsync(appUser, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(registerVM);
            }
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }
            AppUser appUser = await _userManager.FindByEmailAsync(loginVM.Email);
            if (appUser == null)
            {
                ModelState.AddModelError("", "Email or Password is not valid!");
                return View(loginVM);
            }
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(appUser, loginVM.Password, loginVM.RememberMe, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Email or Password is invalid!");
                return View(loginVM);
            }
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordVM changePasswordVM)
        {
            if (!ModelState.IsValid)
            {
                return View(changePasswordVM);
            }
            AppUser appUser = await _userManager.GetUserAsync(User);
            if (appUser == null)
            {
                ModelState.AddModelError("", "Email is invalid!");
                return View(changePasswordVM);
            }
            var result = await _userManager.ChangePasswordAsync(appUser, changePasswordVM.CurrentPassword, changePasswordVM.NewPassword);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            await _signInManager.RefreshSignInAsync(appUser);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordVM forgotPasswordVM)
        {
            if (!ModelState.IsValid)
            {
                return View(forgotPasswordVM);
            }
            AppUser appUser = await _userManager.FindByEmailAsync(forgotPasswordVM.Email);
            if (appUser == null)
            {
                ModelState.AddModelError("", "Email is invalid!");
                return View(forgotPasswordVM);

            }
            var token = await _userManager.GeneratePasswordResetTokenAsync(appUser);
            var link = Url.Action("ResetPassword", "Auth", new { email = forgotPasswordVM.Email, token = token }, Request.Scheme);

            var emailInfo = _context.Emailnfos.First();

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(emailInfo.Email, "TransportMix.az");
            mailMessage.To.Add(new MailAddress(forgotPasswordVM.Email));
            mailMessage.Subject = "Reset Password";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = $"For reseting password <a href={link}>Click Here!</a>";

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(emailInfo.Email, emailInfo.Password);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            await smtpClient.SendMailAsync(mailMessage);

            return RedirectToAction("Index", "Home");
        }
        public IActionResult ResetPassword(string email, string token)
        {
            if (email == null || token == null)
            {
                ModelState.AddModelError("", "Invalid password reset token!");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM resetPasswordVM)
        {
            if (!ModelState.IsValid)
            {
                return View(resetPasswordVM);
            }
            AppUser appUser = await _userManager.FindByEmailAsync(resetPasswordVM.Email);
            if (appUser == null)
            {
                ModelState.AddModelError("", "Email is invalid!");
                return View(resetPasswordVM);
            }
            var result = await _userManager.ResetPasswordAsync(appUser, resetPasswordVM.Token, resetPasswordVM.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Login", "Auth");
            }
            else
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(resetPasswordVM);
            }
        }
    }
}
