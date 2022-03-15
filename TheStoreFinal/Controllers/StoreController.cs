using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheStoreFinal.Data;
using TheStoreFinal.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheStoreFinal.Controllers
{
    public class StoreController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StoreController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IEnumerable<Store> objList = _db.Stores;
            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Store store)
        {
            if (ModelState.IsValid)
            {
                _db.Stores.Add(store);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(store);
            
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Stores.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Store store)
        {
            _db.Stores.Update(store);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Stores.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Stores.Find(id);
            if(obj == null)
            {
                return NotFound();
            }

            _db.Stores.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
