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
    public class StudentiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Studenti
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Studenti;
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Studenti/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Studenti
                .FirstOrDefaultAsync(m => m.BrojNaIndeks == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Studenti/Create
        public IActionResult Create()
        {
            Student st= new Student();
            ViewData["BrojNaIndeks"] = new SelectList(_context.Studenti, st);
            return View();
        }

        // POST: Studenti/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BrojNaIndeks,ImePrezime,TerminId,CustomTerminId")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BrojNaIndeks"] = new SelectList(_context.Studenti, "BrojNaIndeks", "BrojNaIndeks", student.BrojNaIndeks);
            return View(student);
        }

        // GET: Studenti/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Studenti.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            ViewData["BrojNaIndeks"] = new SelectList(_context.Studenti, "BrojNaIndeks", "BrojNaIndeks", student.BrojNaIndeks);
            return View(student);
        }

        // POST: Studenti/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BrojNaIndeks,ImePrezime,TerminId,CustomTerminId")] Student student)
        {
            if (id != student.BrojNaIndeks)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.BrojNaIndeks))
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
            ViewData["BrojNaIndeks"] = new SelectList(_context.Studenti, "BrojNaIndeks", "BrojNaIndeks", student.BrojNaIndeks);
            return View(student);
        }

        // GET: Studenti/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Studenti
                .FirstOrDefaultAsync(m => m.BrojNaIndeks == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Studenti/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Studenti.FindAsync(id);
            _context.Studenti.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Studenti.Any(e => e.BrojNaIndeks == id);
        }
    }
}