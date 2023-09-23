using Microsoft.AspNetCore.Mvc;

namespace MVCTag.Controllers
{
    public class PartialViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tabs()
        {
            ViewData["data"]= "tom and jerry are good friends";

            return View();
        }

        public IActionResult ChildList()
        {
            return View();
        }

        public IActionResult ChildViewData()
        {
            return View();
        }

        public IActionResult Score()
        {
            return View();
        }

        public IActionResult MyView()
        {
            return View();
        }

    }
}
