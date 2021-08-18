using ExamManager.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Service.Interface
{
    interface IPredmetService
    {
        List<Predmet> GetAllPredmeti();

        Predmet GetDetailsForPredemet(Guid ? id);

        void CreateNewPredmet(Predmet p);
        void UpdatePredmet(Predmet p);
        void DeletePredmet(Guid? id);


    }
}
