using Microsoft.AspNetCore.Mvc;
using NWindMVC.Models;

namespace NWindMVC.Controllers
{
    public class OrderController : Controller
    {
        private RepositoryOrder _context;
        public OrderController(RepositoryOrder context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Order> order = _context.GetOrders();
            return View(order);
        }
        public IActionResult Details(int id)
        {
            Order order = _context.PutOrder(id);
            return View(order);
        }
    }
}