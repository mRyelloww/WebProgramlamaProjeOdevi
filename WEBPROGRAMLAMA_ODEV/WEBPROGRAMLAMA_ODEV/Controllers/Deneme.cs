using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBPROGRAMLAMA_ODEV.Controllers
{
    public class Deneme : Controller
    {
        // GET: Deneme
        public ActionResult Index()
        {
            return View();
        }

        // GET: Deneme/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Deneme/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Deneme/Create
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

        // GET: Deneme/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Deneme/Edit/5
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

        // GET: Deneme/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Deneme/Delete/5
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
