using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExamManager.Domain.DomainModel;
using ExamManager.Repository;

namespace ExamManager.Web.Controllers
{
    public class PredmetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PredmetsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Predmets
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Predmeti.Include(p => p.StudiskiCiklus);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Predmets/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var predmet = await _context.Predmeti
                .Include(p => p.StudiskiCiklus)
                .FirstOrDefaultAsync(m => m.KodNaPredmet == id);
            if (predmet == null)
            {
                return NotFound();
            }

            return View(predmet);
        }

        // GET: Predmets/Create
        public IActionResult Create()
        {
            ViewData["StudiskiCiklusId"] = new SelectList(_context.StudickiCiklusi, "CiklusNaStudii", "CiklusNaStudii");
            return View();
        }

        // POST: Predmets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KodNaPredmet,ImeNaPredmet,Semestar,StudiskiCiklusId")] Predmet predmet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(predmet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StudiskiCiklusId"] = new SelectList(_context.StudickiCiklusi, "CiklusNaStudii", "CiklusNaStudii", predmet.StudiskiCiklusId);
            return View(predmet);
        }

        // GET: Predmets/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var predmet = await _context.Predmeti.FindAsync(id);
            if (predmet == null)
            {
                return NotFound();
            }
            ViewData["StudiskiCiklusId"] = new SelectList(_context.StudickiCiklusi, "CiklusNaStudii", "CiklusNaStudii", predmet.StudiskiCiklusId);
            return View(predmet);
        }

        // POST: Predmets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("KodNaPredmet,ImeNaPredmet,Semestar,StudiskiCiklusId")] Predmet predmet)
        {
            if (id != predmet.KodNaPredmet)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(predmet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PredmetExists(predmet.KodNaPredmet))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["StudiskiCiklusId"] = new SelectList(_context.StudickiCiklusi, "CiklusNaStudii", "CiklusNaStudii", predmet.StudiskiCiklusId);
            return View(predmet);
        }

        // GET: Predmets/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var predmet = await _context.Predmeti
                .Include(p => p.StudiskiCiklus)
                .FirstOrDefaultAsync(m => m.KodNaPredmet == id);
            if (predmet == null)
            {
                return NotFound();
            }

            return View(predmet);
        }

        // POST: Predmets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var predmet = await _context.Predmeti.FindAsync(id);
            _context.Predmeti.Remove(predmet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PredmetExists(string id)
        {
            return _context.Predmeti.Any(e => e.KodNaPredmet == id);
        }
    }
}