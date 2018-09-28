using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SaqueNaWeb.Models;

namespace SaqueNaWeb.Controllers
{
    public class LogController : Controller
    {
        private readonly SaqueNaWebContext _context;

        public LogController(SaqueNaWebContext context)
        {
            _context = context;
        }

		// GET: Log/Logged

		public IActionResult Logged(){
			return View();
		}

		// GET: Log
		public IActionResult Index()
        {
			return View();
        }

        // GET: Log/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Log/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,Password,Notes,Total")] Log log)
        {
			if (ModelState.IsValid)
			{
				if (!UsernameExists(log.UserName))
				{
					_context.Add(log);
					await _context.SaveChangesAsync();
					return RedirectToAction(nameof(Index));
				}
            }
            return View(log);
        }

		// POST: Log
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Index(int id, [Bind("Id,UserName,Password,Notes,Total")] Log log)
		{
			if (ModelState.IsValid)
			{
				if (UserExists(log.UserName,log.Password)){
					var x = await _context.Log.FindAsync(id);
					return RedirectToAction(nameof(Logged));
				}
			}
			return	View(log);
		}

		private bool UserExists(string user, string pass){
			return (UsernameExists(user) && _context.Log.Any(j => j.Password == pass));
		}

		private bool UsernameExists(string user){
			return _context.Log.Any(us => us.UserName == user);
		}
    }
}