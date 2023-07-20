using BCrypt.Net;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using notet.BLL.RepositoryPattern.Interfaces;
using notet.MODEL.Entities;
using System.Security.Claims;
using System;

namespace notet.UI.Controllers
{
    public class AuthController : Controller
    {
        IAppUser _repoUser;

        public AuthController(IAppUser repoUser)
        {
            _repoUser = repoUser;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Login(AppUser appUser)
        {
            if (!ModelState.IsValid)
            {
                return View(appUser);
            }
            if (_repoUser.Any(x => x.UserName == appUser.UserName))
            {
                AppUser selectedUser = _repoUser.Default(x => x.UserName == appUser.UserName);
                bool isValid = BCrypt.Net.BCrypt.Verify(appUser.Password, selectedUser.Password);
                if (isValid)
                {
                    List<Claim> claims = new List<Claim>
                    {
                        new Claim ("userName",selectedUser.UserName),
                        new Claim ("userId",selectedUser.Id.ToString()),
                        new Claim ("role",selectedUser.Role.ToString())
                    };
                    ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(principal);
                    if (selectedUser.Role == MODEL.Enums.Role.admin)
                    {
                        return RedirectToAction("DashBoard","Dash", new { area = "Management" });
                    }
                    else if (selectedUser.Role == MODEL.Enums.Role.user)
                    {

                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View();
        }


        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login","Auth");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}

