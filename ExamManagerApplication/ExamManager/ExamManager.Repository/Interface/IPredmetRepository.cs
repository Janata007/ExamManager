using ExamManager.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Repository.Interface
{
    public interface IPredmetRepository
    {
        IEnumerable<Predmet> GetAll();
        Predmet Get(string  kodNaPredmet);
        void Insert(Predmet entity);
        void Update(Predmet entity);
        void Delete(Predmet entity);
    }
}
