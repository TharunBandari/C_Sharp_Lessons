using Microsoft.AspNetCore.Mvc;

namespace MVCTag.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int Add(int x, int y)
        {
            return Add(x, y);

        }
    }
}
