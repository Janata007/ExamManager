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
    public class SproveduvaciController : Controller
    {
        private readonly ISproveduvacService _sproveduvacService;


        public SproveduvaciController(ISproveduvacService sproveduvacService)
        {
            this._sproveduvacService = sproveduvacService;

        }

        // GET: Sproveduvaci
        public IActionResult Index(int? page)
        {
            var sproveduvaci = this._sproveduvacService.GetAllSproveduvaci();
            int totalPages = sproveduvaci.Count() / 10;
            ViewData["totalPages"] = totalPages;
            int currentPage = 1;
            if (page != null)
            {
                sproveduvaci = this._sproveduvacService.GetSproveduvaciPaginated((int)page);
                currentPage = (int)page;
            }
            else
            {
                sproveduvaci = this._sproveduvacService.GetSproveduvaciPaginated(1);
            }
            ViewData["currentPage"] = currentPage;
            int startIndex = currentPage - 2;
            int endIndex = currentPage + 2;
            if (startIndex <= 0)
            {
                startIndex = 1;
                endIndex = 5;
            }
            if (endIndex >= (totalPages + 1))
            {
                endIndex = totalPages + 1;
                if ((endIndex - 5) > 0)
                {
                    startIndex = endIndex - 5;
                }
            }
            ViewData["startIndex"] = startIndex;
            ViewData["endIndex"] = endIndex;
            return View(sproveduvaci);
        }

        // GET: Sproveduvaci/Details/5
        public IActionResult Details(String id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sproveduvac = this._sproveduvacService.GetDetailsForSproveduvac(id);
            if (sproveduvac == null)
            {
                return NotFound();
            }

            return View(sproveduvac);
        }
        // GET: Sproveduvaci/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sproveduvaci/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("SproveduvacId,ImePrezime")] Sproveduvac sproveduvac)
        {
            if (ModelState.IsValid)
            {
                this._sproveduvacService.CreateNewSproveduvac(sproveduvac);
                return RedirectToAction(nameof(Index));
            }
            return View(sproveduvac);
        }


        // POST: Sproveduvaci/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(String id)
        {
            if (id == null)
            {
                return NotFound();
            }
            this._sproveduvacService.DeleteSproveduvac(id);
            return RedirectToAction(nameof(Index));
        }

        private bool SproveduvacExists(String id)
        {
            return this._sproveduvacService.GetDetailsForSproveduvac(id) != null;
        }
    }
}
