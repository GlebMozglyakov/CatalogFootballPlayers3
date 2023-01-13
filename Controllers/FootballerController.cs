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
	}
}
