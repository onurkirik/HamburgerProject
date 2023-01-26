using HamburgerProject.DATA;
using HamburgerProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Diagnostics;

namespace HamburgerProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult Menu()
        {
            var menus = _db.Menus.OrderBy(m => m.Id).ToList();

            return View(menus);
        }

        public IActionResult CreateMenu()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMenu(Menu menu)
        {
            if (ModelState.IsValid)
            {
                _db.Menus.Add(menu);
                _db.SaveChanges();
                return RedirectToAction("Menu");
            }

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