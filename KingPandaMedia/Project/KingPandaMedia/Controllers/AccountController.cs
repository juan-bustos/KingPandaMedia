using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using KingPandaMedia.Models.Tables;
using KingPandaMedia.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace KingPandaMedia.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<KPMUser> userManager;
        private readonly SignInManager<KPMUser> signIn;
        public AccountController(UserManager<KPMUser> userMngr, SignInManager<KPMUser> signInMngr)
        {
            userManager = userMngr;
            signIn = signInMngr;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                KPMUser user = new KPMUser { UserName = registerViewModel.UserName, Email = registerViewModel.Email, /*FirstName = registerViewModel.FirstName, LastName = registerViewModel.LastName,*/ PhoneNumber = registerViewModel.PhoneNumber };
                IdentityResult result = await userManager.CreateAsync(user, registerViewModel.Password);
                if (result.Succeeded)
                {
                    //await signIn.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(registerViewModel);
        }
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return RedirectToAction("index", "home");
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginView, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(loginView.Email);
                if (user != null)
                {
                    await signIn.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signIn.PasswordSignInAsync(user, loginView.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("index", "home");
                    }
                    ModelState.AddModelError(nameof(LoginViewModel.Email), "Invalid user or password");
                }
            }
            return View(loginView);
        }
        [AllowAnonymous]
        public IActionResult FacebookLogin(string returnUrl)
        {
            string redirectUrl = Url.Action("FacebookResponse", "Account", new { ReturnUrl = returnUrl });
            var properties = signIn.ConfigureExternalAuthenticationProperties("Facebook", redirectUrl);
            return new ChallengeResult("Facebook", properties);
        }
        [AllowAnonymous]
        public async Task<IActionResult> FacebookResponse(string returnUrl = "/")
        {
            ExternalLoginInfo info = await signIn.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return RedirectToAction("index", "home");
            }
            var result = await signIn.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, false);
            if (result.Succeeded)
            {
                return Redirect(returnUrl);
            }
            else
            {
                KPMUser user = new KPMUser
                {
                    Email = info.Principal.FindFirst(ClaimTypes.Email).Value,
                    //FirstName = info.Principal.FindFirst(ClaimTypes.GivenName).Value,
                    PhoneNumber = info.Principal.FindFirst(ClaimTypes.HomePhone).Value
                };
                IdentityResult identityResult = await userManager.CreateAsync(user);
                if (identityResult.Succeeded)
                {
                    identityResult = await userManager.AddLoginAsync(user, info);
                    if (identityResult.Succeeded)
                    {
                        await signIn.SignInAsync(user, false);
                        return Redirect(returnUrl);
                    }
                }
                return View(returnUrl);
            }
        }
    }
}