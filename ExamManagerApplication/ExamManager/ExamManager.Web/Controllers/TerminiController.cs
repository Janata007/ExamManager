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
        private readonly ICustomTerminUtilService _customTerminUtilService;

        public TerminiController(ITerminService terminService, IIspitService ispitService, IStudentService studentService,ISproveduvacService sproveduvacService, IProstorijaService prostorijaService)
        {
            this._terminService = terminService;
            this._ispitService = ispitService;
            this._studentService = studentService;
            this._sproveduvacService = sproveduvacService;
            this._prostorijaService = prostorijaService;
        }

        //GET: Index
        public IActionResult Index(int? page)
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
            return View(termini);
        }

        // GET: GenerateScheduleForExams
        public async Task<ActionResult> GenerateScheduleForExams()
        {
            
            HttpClient client = new HttpClient();

            string URI = "http://127.0.0.1:5000/";

            HttpResponseMessage responseMessage = client.GetAsync(URI).Result;

            var result = await responseMessage.Content.ReadAsStringAsync();

            Schedule schedule = JsonConvert.DeserializeObject<Schedule>(result);

            foreach(var t in schedule.schedule)
            {
                Debug.WriteLine(t.teacherId);
                Termin termin = new Termin
                {
                    VremeNaZapocnuvanje = t.timeSlot,
                    VremeNaZavrshuvanje = t.timeSlot.AddMinutes(t.duration),
                    Predmet = this._ispitService.GetDetailsForIspit(t.examId).IspitPoPredmet.ImeNaPredmet,
                    StudentiPolagaatVoTermin = "",
                    Dezuren = t.teacherId,
                    Prostorija = t.roomId

                };
                //this._terminService.CreateNewTermin(termin);
            }

            return RedirectToAction("Index");
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
            foreach (int i in indeksi)
            {
                students.Add(this._studentService.GetDetailsForStudent(i));
            }

            Vkupen vkupen = new Vkupen(termin, students);
            return View(vkupen);
        }

        //GET: Termini/Predmeti
        public List<string> Predmeti()
        {
            return new List<string>()
            {
                "test", "test1", "test3", "testing"
            };
        }
    }
}
