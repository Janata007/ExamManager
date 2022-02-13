using ExamManager.Domain.DomainModel;
using ExamManager.Service.Interface;
using ExamManager.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExamManager.Service.Implementation
{
    public class PredmetService : IPredmetService
    {
        private readonly IPredmetRepository _predmetRepository;
       // private readonly IStudentRepository _studentRepository;
        //private readonly IUserRepository _userRepository;
      //private readonly ISproveduvacRepository _sproveduvacRepository;
        public PredmetService(IPredmetRepository predmetRepository) {
            _predmetRepository = predmetRepository;
        }      

        public void CreateNewPredmet(Predmet p)
        {
            this._predmetRepository.Insert(p); 
        }

        public void DeletePredmet(string id)
        {
            var predmet = this.GetDetailsForPredemet(id);
            this._predmetRepository.Delete(predmet);
        }

        public List<Predmet> FilterPredmetiByName(string name)
        {
            return this._predmetRepository.FilterByName(name).ToList();
        }

        public List<Predmet> GetAllPredmeti()
        {
            return this._predmetRepository.GetAll().ToList();
        }

        public Predmet GetDetailsForPredemet(string id)
        {
            return this._predmetRepository.Get(id);
        }

        public void UpdatePredmet(Predmet p)
        {
            this._predmetRepository.Update(p);
        }
    }
}
