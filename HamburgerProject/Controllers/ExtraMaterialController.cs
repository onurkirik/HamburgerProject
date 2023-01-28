using HamburgerProject.DATA;
using Microsoft.AspNetCore.Mvc;

namespace HamburgerProject.Controllers
{
    public class ExtraMaterialController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ExtraMaterialController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var materials = _db.ExtraMaterials.ToList();

            return View(materials);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ExtraMaterial material)
        {
            _db.ExtraMaterials.Add(material);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var material = _db.ExtraMaterials.Find(id);

            return View(material);
        }

        [HttpPost]
        public IActionResult Update(ExtraMaterial material)
        {
            _db.ExtraMaterials.Update(material);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var material = _db.ExtraMaterials.Find(id);
            _db.ExtraMaterials.Remove(material);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }
}
