using ExamManager.Domain.DomainModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ExamManager.Domain.DTO;
using System.Linq;
using ExamManager.Service.Interface;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;
using System.Diagnostics;
using ExamManager.Repository.Implementation;

namespace ExamManager.Web.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly IProstorijaService _prostorijaService;
        private readonly IIspitService _ispitService;
        private readonly IStudentPolagaPredmetService _studentPolagaPredmetService;
        private readonly ISproveduvacService _sproveduvacService;

        public ApiController(IProstorijaService prostorijaService, IIspitService ispitService, IStudentPolagaPredmetService studentPolagaPredmetService, ISproveduvacService sproveduvacService)
        {
            _prostorijaService = prostorijaService;
            _ispitService = ispitService;
            _studentPolagaPredmetService = studentPolagaPredmetService;
            _sproveduvacService = sproveduvacService;
        }

        [HttpGet("[action]")]
        public List<ProstorijaDTO> getProstorii()
        {
            return this._prostorijaService.GetAllProstoriiDTO();
        }

        [HttpGet("[action]")]
        public List<IspitDTO> getIspiti()
        {
            return this._ispitService.GetlAllIspitDto();
        }

        [HttpGet("[action]")]
        public List<StudentPredmetDTO> getStudentPredmeti()
        {
            return _studentPolagaPredmetService.GetAll();
        }

        [HttpGet("[action]")]
        public List<string> GetAllSproveduvaci()
        {
            return this._sproveduvacService.GetAllSproveduvaci().Select(z => z.SproveduvacId).ToList();
        }

        [HttpGet("[action]")]
        public List<TerminDTO> getTerminiZaIspiti()
        {
            return this._ispitService.GetAllTerminiZaIspiti();
        }
        /*
        [HttpPost("[action]")]
        public HttpResponseMessage receiveScheduledExams([FromBody] RootObject schedule)
        {
            List<CustomTermin> terminiObject = new List<CustomTermin>();
            var json = JsonConvert.SerializeObject(schedule);

            RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(json);

            terminiObject = rootObject.schedule.ToList();
            Debug.WriteLine("BROJ NA TERMINI API CONTROLLER: " + terminiObject.Count);
            int i = 0;
            foreach (CustomTermin objectt in terminiObject) {
                objectt.Id = i;
                i++;
                _customTerminUtilService.AddTermin(objectt);
            }
            Debug.WriteLine("TERMINI VO UTIL API CONTROLLER: " + _customTerminUtilService.GetAllTermini().Count);
            Debug.WriteLine("TERMIN 1 DURATION API CONTROLLER:" + _customTerminUtilService.GetAllTermini().Find(p => p.Id ==0).duration);

            return new HttpResponseMessage(HttpStatusCode.OK);
        }*/
    }
}
