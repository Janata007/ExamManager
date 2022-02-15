using ExamManager.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Service.Interface
{
    public interface ISproveduvacService
    {
        List<Sproveduvac> GetAllSproveduvaci();
        //List<string> GetAllSproceducaiId();
        Sproveduvac GetDetailsForSproveduvac(String id);

        List<Sproveduvac> GetSproveduvaciPaginated(int page);
        List<Sproveduvac> GetDetailsForSproveduvacWithId(List<String> ids);


        void CreateNewSproveduvac(Sproveduvac sp);
        void UpdateSproveduvac(Sproveduvac sp);
        void DeleteSproveduvac(String id);


    }
}
