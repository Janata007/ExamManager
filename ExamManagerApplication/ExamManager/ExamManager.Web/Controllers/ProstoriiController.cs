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
    public class ProstoriiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProstoriiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Prostorii
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Prostorii;
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Prostorii/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prostorija = await _context.Prostorii
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prostorija == null)
            {
                return NotFound();
            }

            return View(prostorija);
        }

        // GET: Prostorii/Create
        public IActionResult Create()
        {
            Prostorija pr = new Prostorija();
            ViewData["Id"] = new SelectList(_context.Prostorii, pr);
            return View();
        }

        // POST: Prostorii/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ime,Kapacitet")] Prostorija prostorija)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prostorija);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id"] = new SelectList(_context.Studenti, "Id", "Id", prostorija.Id);
            return View(prostorija);
        }

        // GET: Prostorii/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prostorija = await _context.Prostorii.FindAsync(id);
            if (prostorija == null)
            {
                return NotFound();
            }
            ViewData["Id"] = new SelectList(_context.Prostorii, "Id", "Id", prostorija.Id);
            return View(prostorija);
        }

        // POST: Prostorii/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Ime,Kapacitet")] Prostorija prostorija)
        {
            if (id != prostorija.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prostorija);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProstorijaExists(prostorija.Id))
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
            ViewData["Id"] = new SelectList(_context.Prostorii, "Id", "Id", prostorija.Id);
            return View(prostorija);
        }

        // GET: Prostorii/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prostorija = await _context.Prostorii
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prostorija == null)
            {
                return NotFound();
            }

            return View(prostorija);
        }

        // POST: Prostorii/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var prostorija = await _context.Prostorii.FindAsync(id);
            _context.Prostorii.Remove(prostorija);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProstorijaExists(Guid id)
        {
            return _context.Prostorii.Any(e => e.Id == id);
        }
    }
}