using ExamManager.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Service.Interface
{
    public interface IPredmetService
    {
        List<Predmet> GetAllPredmeti();

        Predmet GetDetailsForPredemet(string id);

        void CreateNewPredmet(Predmet p);
        void UpdatePredmet(Predmet p);
        void DeletePredmet(string id);


    }
}
