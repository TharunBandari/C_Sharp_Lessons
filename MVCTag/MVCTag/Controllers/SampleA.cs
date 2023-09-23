using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCTag.Controllers
{
    public class SampleA : Controller
    {
        // GET: SampleA

        public ActionResult Start()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: SampleA/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SampleA/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SampleA/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SampleA/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SampleA/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SampleA/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SampleA/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
