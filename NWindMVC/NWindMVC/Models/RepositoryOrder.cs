using NWindMVC;
using NWindMVC.Models;


namespace NWindMVC.Models
{
    public class RepositoryOrder

    {
        public NorthwindContext _context;
        public RepositoryOrder(NorthwindContext context)
        {
            _context = context;
        }
        public List<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }
        public Order PutOrder(int id)
        {
            Console.WriteLine($"Searching for Order with ID: {id}");
            Order order = _context.Orders.Find(id);
            return order;
        }
    }
}
