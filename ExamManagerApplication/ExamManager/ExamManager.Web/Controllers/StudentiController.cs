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
using Microsoft.AspNetCore.Http;
using System.IO;
using ExcelDataReader;
using System.Diagnostics;

namespace ExamManager.Web.Controllers
{
    public class StudentiController : Controller
    {
        private readonly IStudentService _studentiService;
        private readonly IStudentPolagaPredmetService _studentPolagaPredmetService;
        private readonly IPredmetService _predmetService;

        public StudentiController(IStudentService studentService, IStudentPolagaPredmetService studentPolagaPredmetService, IPredmetService predmetService)
        {
            this._studentiService = studentService;
            this._studentPolagaPredmetService = studentPolagaPredmetService;
            this._predmetService = predmetService;
        }

        // GET: Studenti
        public IActionResult Index(int? page)
        {
            var studenti = this._studentiService.Getstudents();
            int totalPages = studenti.Count() / 10;
            ViewData["totalPages"] = totalPages;
            int currentPage = 1;
            if (page != null)
            {
                studenti = this._studentiService.GetStudentiPaginated((int)page);
                currentPage = (int)page;
            }
            else
            {
                studenti = this._studentiService.GetStudentiPaginated(1);
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
            return View(studenti);
        }

        // GET: Studenti/Details/5
        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = this._studentiService.GetDetailsForStudent(id);
            if (student == null)
            {
                return NotFound();
            }
            var tmp = this._studentPolagaPredmetService.GetAllPredmetiForStudent(id);
            foreach(var t in tmp)
            {
                t.Predmet = this._predmetService.GetDetailsForPredmetByKod(t.KodNaPredmet);
            }
            student.StudentPolagaPredmeti = tmp;
            return View(student);
        }


        // POST: Studenti/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            this._studentiService.DeleteStudent(id);
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return this._studentiService.GetDetailsForStudent(id) != null;
        }

        [HttpPost]
        public IActionResult ImportStudenti(IFormFile file)
        {
            string pathToUpload = $"{Directory.GetCurrentDirectory()}\\Files\\{file.FileName}";

            using (FileStream fileStream = System.IO.File.Create(pathToUpload))
            {
                file.CopyTo(fileStream);

                fileStream.Flush();
            }

            List<Student> studenti = this.GetStudentiFromFile(file.FileName);

            foreach (var item in studenti)
            {
                var predmetCheck = this.StudentExists(item.BrojNaIndeks);
                if (!predmetCheck)
                {
                    this._studentiService.CreateNewStudent(item);
                }
                else
                {
                    continue;
                }
            }
            return RedirectToAction("Index", "Studenti");
        }

        private List<Student> GetStudentiFromFile(string fileName)
        {
            List<Student> studenti = new List<Student>();

            string filePath = $"{Directory.GetCurrentDirectory()}\\Files\\{fileName}";

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


            using (var stream = System.IO.File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    while (reader.Read())
                    {
                        studenti.Add(new Student
                        {
                            ImePrezime = reader.GetValue(0).ToString()
                        });
                    }
                }
            }

            return studenti;
        }

        [HttpPost]
        public IActionResult ImportStudentsAndSubjects(IFormFile file)
        {
            string pathToUpload = $"{Directory.GetCurrentDirectory()}\\Files\\{file.FileName}";

            using (FileStream fileStream = System.IO.File.Create(pathToUpload))
            {
                file.CopyTo(fileStream);

                fileStream.Flush();
            }

            List < StudentPolagaPredmet > studentiPredmeti = this.GetStudentsAndSubjects(file.FileName);

            foreach(var item in studentiPredmeti)
            {
                this._studentPolagaPredmetService.Insert(item);
            }
            return RedirectToAction("Index", "Studenti");
        }


        private List<StudentPolagaPredmet> GetStudentsAndSubjects(string fileName)
        {
            List<StudentPolagaPredmet> studentiPredmeti = new List<StudentPolagaPredmet>();

            string filePath = $"{Directory.GetCurrentDirectory()}\\Files\\{fileName}";

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


            using (var stream = System.IO.File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    while (reader.Read())
                    {
                        int indeks = int.Parse(reader.GetValue(0).ToString());
                        string[] predmeti = reader.GetValue(1).ToString().Split(",").Select(p => p.Trim())
                                                                                    .Where(p => !string.IsNullOrWhiteSpace(p))
                                                                                    .ToArray();
                        foreach (string p in predmeti)
                        {
                            studentiPredmeti.Add(new StudentPolagaPredmet
                            {
                                BrojNaIndeks = indeks,
                                KodNaPredmet = p
                            });
                        }
                    }
                }
            }

            return studentiPredmeti;
        }

        public IActionResult DeleteAllStudents()
        {
            foreach (var student in _studentiService.Getstudents())
            {
                int id = student.BrojNaIndeks;
                _studentiService.DeleteStudent(id);
            }
            return RedirectToAction("Index", "Studenti");
        }
    }
}