using ExamManager.Domain.DomainModel;
using ExamManager.Domain.DTO;
using ExamManager.Repository;
using ExamManager.Repository.Implementation;
using ExamManager.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using ClosedXML.Excel;
using System.Threading.Tasks;


namespace ExamManager.Web.Controllers
{
    public class TerminiController : Controller
    {
        private readonly ITerminService _terminService;
        private readonly IIspitService _ispitService;
        private readonly IStudentService _studentService;
        private readonly ISproveduvacService _sproveduvacService;
        private readonly IProstorijaService _prostorijaService;

        public TerminiController(ITerminService terminService, IIspitService ispitService, IStudentService studentService, ISproveduvacService sproveduvacService, IProstorijaService prostorijaService)
        {
            this._terminService = terminService;
            this._ispitService = ispitService;
            this._studentService = studentService;
            this._sproveduvacService = sproveduvacService;
            this._prostorijaService = prostorijaService;
        }

        //GET: Index
        public IActionResult Index(int? page, string? searchSubjects)
        {
            var termini = this._terminService.GetAllTermini();
            int totalPages = termini.Count() / 10;
            ViewData["totalPages"] = totalPages;
            int currentPage = 1;
            if (page != null)
            {
                termini = this._terminService.GetTerminiPaginated((int)page);
                currentPage = (int)page;
            }
            else
            {
                termini = this._terminService.GetTerminiPaginated(1);
            }
            if(searchSubjects != null)
            {
                termini = termini.Where(t => t.Predmet.Contains(searchSubjects)).ToList();
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
            List<DisplayTermin> displayTermini = new List<DisplayTermin>();
            foreach (var ter in termini)
            {
                displayTermini.Add(new DisplayTermin
                {
                    TerminId = ter.Id,
                    Predmet = ter.Predmet,
                    DatumNaPolaganje = ter.VremeNaZapocnuvanje.Date.ToString("dd/MM/yyyy"),
                    BrojNaTermini = this._terminService.GetBrojNaTermini(ter.Predmet)
                });
            }
            ViewData["startIndex"] = startIndex;
            ViewData["endIndex"] = endIndex;
            return View(displayTermini);
        }

        // GET: GenerateScheduleForExams
        public async Task<ActionResult> GenerateScheduleForExams()
        {

            HttpClient client = new HttpClient();

            string URI = "http://127.0.0.1:5000/";

            HttpResponseMessage responseMessage = client.GetAsync(URI).Result;

            var result = await responseMessage.Content.ReadAsStringAsync();

            Schedule schedule = JsonConvert.DeserializeObject<Schedule>(result);

            foreach (var t in schedule.schedule)
            {
                this._terminService.CreateNewTermin(new Termin
                {
                    VremeNaZapocnuvanje = t.timeSlot,
                    VremeNaZavrshuvanje = t.timeSlot.AddMinutes(t.duration),
                    Predmet = this._ispitService.GetDetailsForIspit(t.examId).IspitPoPredmet.ImeNaPredmet,
                    StudentiPolagaatVoTermin = string.Join(",", t.students),
                    Dezuren = t.teacherId,
                    Prostorija = t.roomId
                });
            }

            return RedirectToAction("Index");
        }
        // GET: TerminiController/Details/5
        public ActionResult Details(string predmet)
        {
            if (predmet == null)
            {
                return NotFound();
            }
            List<Termin> termini = this._terminService.GetAllTerminiForPredmet(predmet);

            return View(termini);
        }

        public IActionResult DeleteAllTermini()
        {
            foreach (var termin in this._terminService.GetAllTermini())
            {
                Guid id = termin.Id;
                this._terminService.DeleteTermin(id);
            }
            return RedirectToAction("Index", "Termini");
        }

        [HttpGet]
        public FileContentResult ExportTermini(string id)
        {
            string fileName = "Termini " + id + ".xlsx";
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            Debug.WriteLine("export");
            using (var workbook = new XLWorkbook())
            {
                IXLWorksheet worksheet = workbook.Worksheets.Add("Termini");

                var termini = this._terminService.GetAllTerminiForPredmet(id);

                worksheet.Cell(1, 1).Value = "Предмет";
                worksheet.Cell(1, 2).Value = id;

                int row = 2;
                for (int i = 0; i < termini.Count; i++)
                {
                    var item = termini[i];
                    worksheet.Cell(row, 1).Value = "Термин" + (i + 1);
                    row++;
                    worksheet.Cell(row, 1).Value = "Датум на полагање: " + item.VremeNaZapocnuvanje.Date.ToString("dd/MM/yyyy");
                    row += 2;
                    worksheet.Cell(row, 1).Value = "Студент";
                    worksheet.Cell(row, 2).Value = "Просторија";
                    worksheet.Cell(row, 3).Value = "Професор";
                    worksheet.Cell(row, 4).Value = "Почеток на полагање";
                    worksheet.Cell(row, 5).Value = "Крај на полагање";
                    row++;
                    var studenti = item.StudentiPolagaatVoTermin.Split(",");
                    string from = item.VremeNaZapocnuvanje.ToString("HH:mm");
                    string to = item.VremeNaZavrshuvanje.ToString("HH:mm");
                    for (int j = 0; j < studenti.Length; j++)
                    {
                        worksheet.Cell(row, 1).Value = studenti[j];
                        worksheet.Cell(row, 2).Value = item.Prostorija;
                        worksheet.Cell(row, 3).Value = item.Dezuren;
                        worksheet.Cell(row, 4).Value = from;
                        worksheet.Cell(row, 5).Value = to;
                        row++;
                    }

                    row += 2;


                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(content, contentType, fileName);
                }
            }

        }

    }
}
