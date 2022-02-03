using ExamManager.Domain.DomainModel;
using ExamManager.Repository.Interface;
using ExamManager.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamManager.Service.Implementation
{
    public class StudiskiCiklusService : IStudiskiCiklusService
    {
        private readonly IStudiskiCiklusRepository _studiskiCiklusRepository;

        public StudiskiCiklusService(IStudiskiCiklusRepository studiskiCiklusRepository) {

            this._studiskiCiklusRepository = studiskiCiklusRepository;
        }

        public void CreateNewStudiskiCiklus(StudiskiCiklus sc)
        {
            this._studiskiCiklusRepository.Insert(sc);
        }

        public void DeleteStudiskiCiklus(string id)
        {
            var sc = this.GetDetailsForStudiskiCiklus(id);
            this._studiskiCiklusRepository.Delete(sc);
        }

        public List<StudiskiCiklus> GetAllCiklusi()
        {
            return this._studiskiCiklusRepository.GetAll().ToList();
        }

        public StudiskiCiklus GetDetailsForStudiskiCiklus(string id)
        {
            return this._studiskiCiklusRepository.Get(id);
        }

        public void UpdateStudiskiCiklus(StudiskiCiklus sc)
        {
            this._studiskiCiklusRepository.Update(sc);
        }
    }
}
