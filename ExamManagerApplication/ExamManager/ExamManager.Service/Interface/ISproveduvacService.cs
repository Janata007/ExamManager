using ExamManager.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Service.Interface
{
    interface ISproveduvacService
    {
        List<Sproveduvac> GetAllSproveduvaci();

        Sproveduvac GetDetailsForSproveduvac(Guid? id);

        void CreateNewSproveduvac(Sproveduvac sp);
        void UpdateSproveduvac(Sproveduvac sp);
        void DeleteSproveduvac(Guid? id);


    }
}
