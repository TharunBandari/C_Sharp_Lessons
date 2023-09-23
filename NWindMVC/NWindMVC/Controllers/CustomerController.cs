﻿using Microsoft.AspNetCore.Mvc;
using NWindMVC.Models;
using NWindMVC;

namespace NwindMVC.Controllers
{
    public class CustomerController : Controller
    {
        private RepositoryCustomer _repositoryCustomer;



        public CustomerController(RepositoryCustomer _repoCustomer)
        {
            _repositoryCustomer = _repoCustomer;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            List<string> customerIds = _repositoryCustomer.GetAllCustomerIDs();
            CustomerIdsViewModel idsViewModel = new CustomerIdsViewModel(customerIds);
            return View(idsViewModel);
        }



        // GET: CustomerController/Details/5
        public ActionResult Details(string id)
        {
            Customer customer = _repositoryCustomer.FindCustomerByID(id);
            List<Customer> detail = _repositoryCustomer.FindCustomerDetailByCustomerId(id);
            ViewData["Customer"] = detail;
            return View(customer);
        }



        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }



        // POST: CustomerController/Create
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



        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }



        // POST: CustomerController/Edit/5
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



        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }



        // POST: CustomerController/Delete/5
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