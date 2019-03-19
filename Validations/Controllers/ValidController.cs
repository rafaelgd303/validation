using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Validations.Models;

namespace Validations.Controllers
{
    public class ValidController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            AddUserVM model = new AddUserVM();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(AddUserVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Index");
        }

        // GET: Valid/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Valid/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Valid/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Valid/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Valid/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Valid/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Valid/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}