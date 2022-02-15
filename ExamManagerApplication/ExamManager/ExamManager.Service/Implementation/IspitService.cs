using ExamManager.Domain.DomainModel;
using ExamManager.Repository.Interface;
using ExamManager.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ExamManager.Domain.DTO;

namespace ExamManager.Service.Implementation
{
    public class IspitService : IIspitService
    {
        private readonly IRepository<Ispit> _ispitRepository;
        private readonly IIspitRepository _detailsRepository;

        public IspitService(IRepository<Ispit> ispitRepository, IIspitRepository repository) {
            _ispitRepository = ispitRepository;
            this._detailsRepository = repository;
        }
        public void CreateNewIspit(Ispit i)
        {
            this._ispitRepository.Insert(i);
        }

        public void DeleteIspit(Guid? id)
        {
            var ispit = this.GetDetailsForIspit(id);
            this._ispitRepository.Delete(ispit);
        }

        public List<Ispit> GetAllIspiti()
        {
            return this._ispitRepository.GetAll().ToList();
        }

        public List<TerminDTO> GetAllTerminiZaIspiti()
        {
            List<TerminDTO> termini = new List<TerminDTO>();
            foreach (var ispit in this._ispitRepository.GetAll())
            {
                List<DateTime> dateTimes = new List<DateTime>();
                for (int i = 0; i < ispit.BrojNaTermin; i++)
                {
                    dateTimes.Add(ispit.PolaganjeOd.AddMinutes((i + 1) * ispit.VremetraenjeNaTerminVoMinuti));
                }
                termini.Add(new TerminDTO { ispitId = ispit.Id, Termini = dateTimes});
            }
            return termini;
        }

        public Ispit GetDetailsForIspit(Guid? id)
        {
            return this._detailsRepository.GetDetailsForIspit(id);
        }

        public List<IspitDTO> GetlAllIspitDto()
        {
            return this._ispitRepository.GetAll().Select(z => new IspitDTO
            {
                ispitId = z.Id,
                KodNaPredmet = z.KodNaPredmet,
                Vremetraenje = z.VremetraenjeNaTerminVoMinuti
            }).ToList();
        }

        public void UpdateIspit(Ispit i)
        {
            this._ispitRepository.Update(i);
        }
    }
}
