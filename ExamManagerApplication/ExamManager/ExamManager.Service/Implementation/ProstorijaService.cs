using ExamManager.Domain.DomainModel;
using ExamManager.Domain.DTO;
using ExamManager.Repository.Interface;
using ExamManager.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamManager.Service.Implementation
{
    public class ProstorijaService : IProstorijaService
    {
        private readonly IRepository<Prostorija> _prostoriiRepository;
        public static Random random = new Random();

        public ProstorijaService(IRepository<Prostorija> repository)
        {
            this._prostoriiRepository = repository;
        }
        public void CreateNewProstorija(Prostorija p)
        {
            this._prostoriiRepository.Insert(p);
        }

        public void DeleteProstorija(Guid id)
        {
            Prostorija prostorija = this.GetDetailsForProstorija(id);
            this._prostoriiRepository.Delete(prostorija);
        }

        public List<Prostorija> GetAllProstorii()
        {
            return this._prostoriiRepository.GetAll().ToList();
        }

        public Prostorija GetDetailsForProstorija(Guid id)
        {
            return this._prostoriiRepository.Get(id);
        }

        public void UpdateProstorija(Prostorija p)
        {
            this._prostoriiRepository.Update(p);
        }

        public List<ProstorijaDTO> GetAllProstoriiDTO()
        {
            return this._prostoriiRepository.GetAll().Select(z => new ProstorijaDTO { Prostorija = z.Ime, Kapacitet = z.Kapacitet }).ToList();
        }

        public Guid GetProstorijaByName(string name)
        {
            return this._prostoriiRepository.GetAll().Where(p => p.Ime.Equals(name)).Select(p => p.Id).FirstOrDefault();
        }

        public Prostorija GetDetailsForProstorijaByName(string name)
        {
            return this._prostoriiRepository.GetAll().Where(p => p.Ime.Equals(name)).FirstOrDefault();
        }
    }
}
