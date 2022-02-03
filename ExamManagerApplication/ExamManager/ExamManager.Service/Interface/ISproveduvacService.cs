using ExamManager.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Service.Interface
{
    public interface ISproveduvacService
    {
        List<Sproveduvac> GetAllSproveduvaci();
        List<string> GetAllSproceducaiId();
        Sproveduvac GetDetailsForSproveduvac(string id);

        void CreateNewSproveduvac(Sproveduvac sp);
        void UpdateSproveduvac(Sproveduvac sp);
        void DeleteSproveduvac(string id);


    }
}
