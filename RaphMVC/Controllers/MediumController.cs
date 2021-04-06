using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RaphMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaphMVC.Controllers
{
    public class MediumController : Controller
    {
        List<IMedium> Media;

        public MediumController()
        {
            Media = new List<IMedium>()
            {
                new Song(),
                new Game(),
                new Movie()
            };
        }
        // GET: MediumController
        public ActionResult Index()
        {
            return View(Media);
        }

        // GET: MediumController/Details/5
        public ActionResult Details(string Name)
        {
            return View(Media.Where(n=>n.Name==Name).FirstOrDefault());
        }

        // GET: MediumController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MediumController/Create
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

        // GET: MediumController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MediumController/Edit/5
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

        // GET: MediumController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MediumController/Delete/5
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
