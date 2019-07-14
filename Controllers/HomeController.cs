using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValkyrieIMS.Models;

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

                _context.Add(User);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Welcome));
            }
            return View(User);
        }
         
        public IActionResult Welcome() {
            return View();
        }
        
        public IActionResult Login()
        {
            return View();
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
