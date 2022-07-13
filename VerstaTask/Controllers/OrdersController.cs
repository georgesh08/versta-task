using Microsoft.AspNetCore.Mvc;
using VerstaTask.Data;
using VerstaTask.Models;

namespace VerstaTask.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IDatabaseContext _context;

        public OrdersController(IDatabaseContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            var orders = await _context.GetOrders();
            return View(orders);
        }

        public IActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SenderCity,SenderAddress,RecipientCity,RecipientAddress,CargoWeight,TransportationDate")] Order order)
        {
            if (!ModelState.IsValid) return View(order);
            order.Id = Guid.NewGuid();
            await _context.AddOrder(order);
            await _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
