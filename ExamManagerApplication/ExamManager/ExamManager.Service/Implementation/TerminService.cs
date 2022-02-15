using ExamManager.Domain.DomainModel;
using ExamManager.Repository.Interface;
using ExamManager.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamManager.Service.Implementation
{
    public class TerminService : ITerminService
    {
        private readonly IRepository<Termin> _terminiRepository;

        public TerminService(IRepository<Termin> terminRepository)
        {
            this._terminiRepository = terminRepository;
        }

        public void CreateNewTermin(Termin t)
        {
            this._terminiRepository.Insert(t);
        }

        public void DeleteTermin(Guid id)
        {
            var termin = this.GetDetailsForTermin(id);
            this._terminiRepository.Delete(termin);
        }

        public List<Termin> GetAllTermini()
        {
            return this._terminiRepository.GetAll().ToList();
        }

        public List<Termin> GetAllTerminiForPredmet(string KodNaPredmet)
        {
            return this._terminiRepository.GetAll().Where(t => t.Predmet == KodNaPredmet).ToList();
        }

        public int GetBrojNaTermini(string KodNaPredmet)
        {
            return this._terminiRepository.GetAll().Where(t => t.Predmet == KodNaPredmet).Count();
        }

        public Termin GetDetailsForTermin(Guid id)
        {
            return this._terminiRepository.Get(id);
        }

        public List<Termin> GetTerminiPaginated(int page)
        {
            int maxRows = 10;
            return this.GetAllTermini().OrderBy(z => z.Id).Skip((page - 1) * maxRows).Take(maxRows).ToList();
        }
    }
}
