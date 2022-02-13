using System;
using ClosedXML.Excel;
using ExcelDataReader;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExamManager.Domain.DomainModel;
using ExamManager.Repository;
using ExamManager.Domain.Enumerations;
using ExamManager.Service.Interface;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace ExamManager.Web.Controllers
{
    public class PredmetiController : Controller
    {
        private readonly IPredmetService _predmetService;
        private readonly IStudiskiCiklusService _studiskiCiklusService;

        public PredmetiController(IPredmetService predmetService, IStudiskiCiklusService studiskiCiklusService)
        {
            this._predmetService = predmetService;
            this._studiskiCiklusService = studiskiCiklusService;
        }

        //GET: Predmeti
        public IActionResult Index(string? searchString)
        {
            var sitePredmeti = _predmetService.GetAllPredmeti();
            if (searchString != null)
            {
                sitePredmeti = _predmetService.FilterPredmetiByName(searchString);
            }
            return View(sitePredmeti);
        }

        // GET: Predmets/Details/5
        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var predmet = this._predmetService.GetDetailsForPredemet(id);

            if (predmet == null)
            {
                return NotFound();
            }

            return View(predmet);
        }

        // GET: Predmets/Create
        public IActionResult Create()
        {
            ViewData["StudiskiCiklusId"] = new SelectList(this._studiskiCiklusService.GetAllCiklusi(), "CiklusNaStudii", "CiklusNaStudii");
            ViewData["Semestar"] = new SelectList(Enum.GetValues(typeof(Semestar)).Cast<Semestar>().Select(v => v.ToString()).ToList());
            return View();
        }

        // POST: Predmets/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("KodNaPredmet,ImeNaPredmet,Semestar,StudiskiCiklusId")] Predmet predmet)
        {
            if (ModelState.IsValid)
            {
                this._predmetService.CreateNewPredmet(predmet);
                return RedirectToAction(nameof(Index));
            }
            ViewData["StudiskiCiklusId"] = new SelectList(this._studiskiCiklusService.GetAllCiklusi(), "CiklusNaStudii", "CiklusNaStudii");
            ViewData["Semestar"] = new SelectList(Enum.GetValues(typeof(Semestar)).Cast<Semestar>().Select(v => v.ToString()).ToList());
            return View(predmet);
        }

        // GET: Predmets/Edit/5
        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var predmet = this._predmetService.GetDetailsForPredemet(id);
            if (predmet == null)
            {
                return NotFound();
            }
            ViewData["StudiskiCiklusId"] = new SelectList(this._studiskiCiklusService.GetAllCiklusi(), "CiklusNaStudii", "CiklusNaStudii");
            ViewData["Semestar"] = new SelectList(Enum.GetValues(typeof(Semestar)).Cast<Semestar>().Select(v => v.ToString()).ToList());
            return View(predmet);
        }

        // POST: Predmets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, [Bind("KodNaPredmet,ImeNaPredmet,Semestar,StudiskiCiklusId")] Predmet predmet)
        {
            if (id != predmet.KodNaPredmet)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this._predmetService.UpdatePredmet(predmet);
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
            ViewData["StudiskiCiklusId"] = new SelectList(this._studiskiCiklusService.GetAllCiklusi(), "CiklusNaStudii", "CiklusNaStudii");
            ViewData["Semestar"] = new SelectList(Enum.GetValues(typeof(Semestar)).Cast<Semestar>().Select(v => v.ToString()).ToList());
            return View(predmet);
        }

        // POST: Predmets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            this._predmetService.DeletePredmet(id);
            return RedirectToAction(nameof(Index));
        }

        private bool PredmetExists(string id)
        {
            return this._predmetService.GetDetailsForPredemet(id) != null;
        }

        [HttpPost]
        public IActionResult ImportPredmeti(IFormFile file)
        {
            string pathToUpload = $"{Directory.GetCurrentDirectory()}\\Files\\{file.FileName}";

            using (FileStream fileStream = System.IO.File.Create(pathToUpload))
            {
                file.CopyTo(fileStream);

                fileStream.Flush();
            }

            List<Predmet> predmeti = this.GetPredmetiFromFile(file.FileName);

            foreach(var item in predmeti)
            {
                var predmetCheck = this.PredmetExists(item.KodNaPredmet);
                if(!predmetCheck)
                {
                    this._predmetService.CreateNewPredmet(item);
                }
                else
                {
                    continue;
                }
            }
            return RedirectToAction("Index", "Predmeti");
        }

        private List<Predmet> GetPredmetiFromFile(string fileName)
        {
            List<Predmet> predmeti = new List<Predmet>();

            string filePath = $"{Directory.GetCurrentDirectory()}\\Files\\{fileName}";

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


            using (var stream = System.IO.File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    while (reader.Read())
                    {
                        predmeti.Add(new Predmet
                        {
                            KodNaPredmet = reader.GetValue(0).ToString(),
                            ImeNaPredmet = reader.GetValue(1).ToString(),
                            Semestar = reader.GetValue(2).ToString().Equals("L") ? Semestar.Leten : Semestar.Zimski,
                            StudiskiCiklusId = "Додипломски"
                        });
                    }
                }
            }

            return predmeti;
        }
    }
}