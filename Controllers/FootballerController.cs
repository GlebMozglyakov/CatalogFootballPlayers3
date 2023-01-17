using CatalogFootballPlayers3.Data;
using CatalogFootballPlayers3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace CatalogFootballPlayers3.Controllers
{
    public class FootballerController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FootballerController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Footballer> objlist = _db.Footballer;
            return View(objlist);
        }

        //GET - CREATE
		public IActionResult Create()
		{
			return View();
		}

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
		public IActionResult Create(Footballer obj)
		{
            if (ModelState.IsValid)
            {
                _db.Footballer.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
		}

		//GET - EDIT
		public IActionResult Edit(int? id)
		{
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Footballer.Find(id);

            if (obj == null) 
            {
                return NotFound();
            }

			return View(obj);
		}

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Footballer obj)
        {
            if (ModelState.IsValid)
            {
                _db.Footballer.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Footballer.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Footballer.Find(id);
            
            if (obj == null)
            {
                return NotFound();
            }
        
            _db.Footballer.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
