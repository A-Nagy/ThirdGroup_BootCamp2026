using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using ThirdGroup_1.Data;
using ThirdGroup_1.Models;
using ThirdGroup_1.Models.ViewModels;
using ThirdGroup_1.Security;

namespace ThirdGroup_1.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            if (User.Identity?.IsAuthenticated == true) 
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.ReturnUrl = returnUrl;

            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(LoginViewModel model, string? returnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ReturnUrl = returnUrl;
                return View(model);
            }

            User? user = _context.Users.Include(u => u.Roles)
                                       .ThenInclude(r => r.Permissions)
                                       .FirstOrDefault(u => u.UserName == model.UserName);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid UserName Or Password");
                ViewBag.ReturnUrl = returnUrl;
                return View(model);
            }

            if (user.Password != model.Password)
            {
                ModelState.AddModelError(string.Empty, "Invalid UserName Or Password");
                ViewBag.ReturnUrl = returnUrl;
                return View(model);
            }
            List<Claim> claims =
                new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim("UserName", user.Name)
                };
            foreach (Role role in user.Roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role.Name));
            }

            List<string> permissions =
                user.Roles.SelectMany(role => role.Permissions).
                Select(permission => permission.Name).Distinct().ToList();

            foreach (string permission in permissions)
            {
                claims.Add(new Claim(PermissionsNames.ClaimType,permission));
            }

            ClaimsIdentity identity = new ClaimsIdentity(claims,
                                      CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);

            ClaimsPrincipal principal = new ClaimsPrincipal(identity);

            AuthenticationProperties properties = new AuthenticationProperties
            {
                IsPersistent = model.RememberMe,
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(30)
            };

            HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                principal, 
                properties
                );

            if (returnUrl == null)
            {
                return RedirectToAction("Index", "Home");

            }
            else 
            {
                return Redirect(returnUrl);
            }

        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await  HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login");
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult AccessDenied() 
        {
            return View();
        }
        [Authorize]
        [HttpGet]
        public IActionResult MyAccess() 
        {
            return View();
        }
    }
}
