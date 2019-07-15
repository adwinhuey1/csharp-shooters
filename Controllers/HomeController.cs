using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ValkyrieIMS.Models;
using ValkyrieIMS.Services;

namespace ValkyrieIMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ValkyrieIMSContext _context;
        public HomeController(ValkyrieIMSContext context) {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User User)
        {
           if (ModelState.IsValid) {
                // Manual Auth is custom class to hold hash methods
                User.Password = ManualAuth.Sha256(User.Password);
                // Add user and save changes to database.
                _context.Add(User);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Welcome));
            }
            else {
                return View("Error");
            }
        }
         
        public IActionResult Welcome() {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(User user) {

            if (ModelState.IsValid) {
                User GetUser = await _context.Users.SingleOrDefaultAsync(u => u.UserName == user.UserName);
                
                if (GetUser != null) {
                    if (ManualAuth.Sha256Check(user.Password, GetUser.Password)) {
                        return View("LoginSuccess");
                    }
                }
            }
            return View("LoginFail");
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
