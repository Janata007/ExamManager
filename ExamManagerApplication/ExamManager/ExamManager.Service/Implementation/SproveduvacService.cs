using ExamManager.Domain.DomainModel;
using ExamManager.Repository.Interface;
using ExamManager.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamManager.Service.Implementation
{
    public class SproveduvacService : ISproveduvacService
    {
        
        private readonly ISproveduvacRepository _sproveduvacRepository;
        public SproveduvacService(ISproveduvacRepository sproveduvacRepository)
        {
            _sproveduvacRepository = sproveduvacRepository;

        }

        public void CreateNewSproveduvac(Sproveduvac sp)
        {
            this._sproveduvacRepository.Insert(sp);
        }

        public void DeleteSproveduvac(string id)
        {
            var sp = this.GetDetailsForSproveduvac(id);
            this._sproveduvacRepository.Delete(sp);
        }

        public List<string> GetAllSproceducaiId()
        {
            return this._sproveduvacRepository.GetAll().Select(z => z.SproveduvacId).ToList();
        }

        public List<Sproveduvac> GetAllSproveduvaci()
        {
            return this._sproveduvacRepository.GetAll().ToList();
        }

        public Sproveduvac GetDetailsForSproveduvac(string id)
        {
            return this._sproveduvacRepository.Get(id);
        }

        public void UpdateSproveduvac(Sproveduvac sp)
        {
            this._sproveduvacRepository.Update(sp);
        }
    }
}
