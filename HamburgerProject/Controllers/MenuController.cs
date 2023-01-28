using HamburgerProject.DATA;
using Microsoft.AspNetCore.Mvc;

namespace HamburgerProject.Controllers
{
    public class MenuController : Controller
    {
        private readonly ApplicationDbContext _db;


        public MenuController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var menus = _db.Menus.OrderBy(m => m.Id).ToList();

            return View(menus);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Menu menu)
        {
            if (ModelState.IsValid)
            {
                _db.Menus.Add(menu);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var menu = _db.Menus.Find(id);

            return View(menu);
        }

        [HttpPost]
        public IActionResult Update(Menu menu)
        {
            _db.Menus.Update(menu);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var menu = _db.Menus.Find(id);
            _db.Menus.Remove(menu);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }
}
