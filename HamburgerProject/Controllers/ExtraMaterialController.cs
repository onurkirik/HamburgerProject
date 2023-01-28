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
    }
}
