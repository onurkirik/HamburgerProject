using HamburgerProject.DATA;
using HamburgerProject.ENUMS;
using HamburgerProject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HamburgerProject.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _db;

        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var orders = _db.Orders.Include(o => o.Menu).Include(o => o.EkstraMaterials).ToList();

            var vm = new OrderListViewModel()
            {
                Orders = orders
            };

            return View(vm);
        }


        [HttpGet]
        public IActionResult Create()
        {
            var vm = new OrderCreateViewModel()
            {
                Menus = _db.Menus.ToList(),
                ExtraMaterials = _db.ExtraMaterials.ToList()
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(OrderCreateViewModel vm)
        {
            var order = new Order()
            {
                Number = vm.OrderNumber,
                MenuId = vm.MenuId,
                Size = vm.Size,
                EkstraMaterials = _db.ExtraMaterials.Where(m => vm.MaterialIds.Any(id => m.Id == id)).ToList(),
                Menu = _db.Menus.Find(vm.MenuId)

            };

            _db.SaveChanges();
            _db.Orders.Add(order);
            CalculatePrice(order);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update()
        {
            return View();
        }
      
        private void CalculatePrice(Order order)
        {
            order.TotalPrice = 0;
            order.TotalPrice += order.Menu.Price;

            if (order.Size == Size.Medium)
                order.TotalPrice += order.TotalPrice + 10;
            else if (order.Size == Size.Large)
                order.TotalPrice += order.TotalPrice + 20;

            foreach (var material in order.EkstraMaterials)
            {
                order.TotalPrice += material.Price;
            }

            order.TotalPrice *= order.Number;
        }
    }
}
