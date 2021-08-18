using ExamManager.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Service.Interface
{
    interface IStudiskiCiklusService
    {
        List<StudiskiCiklus> GetAllCiklusi();

        StudiskiCiklus GetDetailsForStudiskiCiklus(string id);

        void CreateNewStudiskiCiklus(StudiskiCiklus sc);
        void UpdateStudiskiCiklus(StudiskiCiklus sc);
        void DeleteStudiskiCiklus(string id);


    }
}
