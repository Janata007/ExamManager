using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExamManager.Domain.DomainModel;
using ExamManager.Repository;
using ExamManager.Service.Interface;

namespace ExamManager.Web.Controllers
{
    public class ProstoriiController : Controller
    {

        private readonly IProstorijaService _prostoriiService;

        public ProstoriiController(IProstorijaService prostorijaService)
        {
            this._prostoriiService = prostorijaService;
        }

        //GET: Prostorii
        public IActionResult Index()
        {
            var prostorii = _prostoriiService.GetAllProstorii();
            return View(prostorii);
        }
        // GET: Prostorii/Details/5
        public IActionResult Details(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prostorija = this._prostoriiService.GetDetailsForProstorija(id);

            if (prostorija == null)
            {
                return NotFound();
            }

            return View(prostorija);
        }

        // GET: Prostorii/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Prostorii/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Ime,Kapacitet")] Prostorija prostorija)
        {
            if (ModelState.IsValid)
            {
                this._prostoriiService.CreateNewProstorija(prostorija);
                return RedirectToAction(nameof(Index));
            }
            return View(prostorija);
        }

        // GET: Prostorii/Edit/5
        public IActionResult Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prostorija = this._prostoriiService.GetDetailsForProstorija(id);
            if (prostorija == null)
            {
                return NotFound();
            }

            return View(prostorija);
        }

        // POST: Prostorii/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Id,Ime,Kapacitet")] Prostorija prostorija)
        {
            if (id != prostorija.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this._prostoriiService.UpdateProstorija(prostorija);
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
            return View(prostorija);
        }

        // POST: Prostorii/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }
            this._prostoriiService.DeleteProstorija(id);
            return RedirectToAction(nameof(Index));
        }

        private bool ProstorijaExists(Guid id)
        {
            return this._prostoriiService.GetDetailsForProstorija(id) != null;
        }
    }
}