using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SaqueNaWeb.Models;
using Microsoft.AspNetCore.Http;
using System.Web;
using System.Diagnostics;

namespace SaqueNaWeb.Controllers
{
    public class LogController : Controller
    {
        private readonly SaqueNaWebContext _context;

        public LogController(SaqueNaWebContext context)
        {
            _context = context;
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


		// GET: Log/Logged/5
		public async Task<IActionResult> Logged([Bind("Id,UserName,Password,Notes,Total")] Log log)
		{
			if (log == null)
			{
				return NotFound();
			}

			if(ModelState.IsValid)
			{
				var b = _context.Log.Where(x => x.UserName == log.UserName).FirstOrDefault();
			}
			return View(log);
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
		public async Task<IActionResult> Index([Bind("Id,UserName,Password,Notes,Total")] Log log)
		{
			if (ModelState.IsValid)
			{
				if (UserExists(log.UserName,log.Password)){
					var b = _context.Log.Where(x => x.UserName == log.UserName).FirstOrDefault();
					int[] not = TotalNotas((int)log.Total);
					int soma = 0;
					for (int i = 0; i<not.Length;i++)
					{
						soma += not[i];
					}
					b.Notes = soma;
					b.Total = log.Total;
					_context.Update(b);
					await _context.SaveChangesAsync();
					TempData["100"] = not[1];
					TempData["50"] = not[2];
					TempData["20"] = not[3];
					TempData["10"] = not[4];
					TempData["5"] = not[5];
					TempData["2"] = not[6];
					TempData["Total"] = soma;
					return RedirectToAction(nameof(Logged));
				}
			}
			return	View(log);
		}

		private bool LogExists(int id)
		{
			return _context.Log.Any(e => e.Id == id);
		}

		private bool UserExists(string user, string pass){
			return (UsernameExists(user) && _context.Log.Any(j => j.Password == pass));
		}

		private bool UsernameExists(string user){
			return _context.Log.Any(us => us.UserName == user);
		}

		private int[] Notas()
		{
			int[] notes = new int[7] { 0, 100, 50, 20, 10, 5, 2 };
			return notes;
		}

		private int NroNotas()
		{
			return Notas().Length - 1;
		}

		private int[] TotalNotas(int saque)
		{
			int[] moedas = new int[saque + 1];
			int[] min = new int[saque + 1];
			int[] opt = new int[NroNotas()];
			int coin = 0;
			int mini;

			min[0] = 0;
			moedas[0] = 0;

			for (int i = 1; i <= saque; i++)
			{
				mini = 999;
				for (int j = 1; j <= NroNotas(); j++)
				{
					if (Notas()[j] <= i)
					{
						if (1 + min[i - Notas()[j]] < mini)
						{
							mini = 1 + min[i - Notas()[j]];
							coin = j;
						}
					}
				}
				min[i] = mini;
				moedas[i] = coin;

			}

			int[] coins = new int[saque + 1];
			int b = saque;
			while (b > 0)
			{
				coins[b] = Notas()[moedas[b]];
				b = b - Notas()[moedas[b]];
			}

			int[] total = new int[7] { 0, 0, 0, 0, 0, 0, 0 };


			for (int i = 0; i < coins.Length; i++)
			{
				if (coins[i] == 100)
				{
					total[1]++;
				}
				if (coins[i] == 50)
				{
					total[2]++;
				}
				if (coins[i] == 20)
				{
					total[3]++;
				}
				if (coins[i] == 10)
				{
					total[4]++;
				}
				if (coins[i] == 5)
				{
					total[5]++;
				}
				if (coins[i] == 2)
				{
					total[6]++;
				}
			}
			return total;
		}
    }
}