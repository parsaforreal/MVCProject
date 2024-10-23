using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using System.Diagnostics;

namespace MVCProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private UserManager<IdentityUser> _userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {           
            return View();
        }

        public IActionResult PrivacyAsync()
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
