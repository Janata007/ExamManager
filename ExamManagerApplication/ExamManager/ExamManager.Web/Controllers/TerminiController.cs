using ExamManager.Domain.DomainModel;
using ExamManager.Repository;
using ExamManager.Repository.Implementation;
using ExamManager.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ExamManager.Web.Controllers
{
    public class TerminiController : Controller
    {
        private readonly ICustomTerminUtilService _customTerminUtilService;
        private readonly IStudentService _studentService;
        private readonly ApplicationDbContext _context;

        public TerminiController(IStudentService studentService, ICustomTerminUtilService customTerminUtilService, ApplicationDbContext context) { 
        _customTerminUtilService = customTerminUtilService;
            _context = context;
            _studentService = studentService;
        }

        // GET: TerminiController
        public async Task<ActionResult> Index()
        {
           this._customTerminUtilService.invokePost();
            List<CustomTermin> termini = this._customTerminUtilService.GetAllTermini();
            Debug.WriteLine("TERMINI VO TERMINI KONTROLER: " + termini.Count);
            return View(termini);
        }

        // GET: TerminiController/Details/5
        public ActionResult Details(int id)
        {

            if (id == null)
            {
                return NotFound();
            }
            CustomTermin termin = this._customTerminUtilService.GetDetailsForTermin(id);
            List<int> indeksi = termin.students;
            List<Student> students = new List<Student>();
            foreach (int i in indeksi) {
                students.Add(this._studentService.GetDetailsForStudent(i));
            }

            Vkupen vkupen = new Vkupen(termin, students);
            return View(vkupen);
        }

        // GET: TerminiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TerminiController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TerminiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TerminiController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TerminiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TerminiController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
