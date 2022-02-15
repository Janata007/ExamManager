using ExamManager.Domain.DomainModel;
using ExamManager.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Service.Interface
{
    public interface IProstorijaService
    {
        List<Prostorija> GetAllProstorii();
        List<ProstorijaDTO> GetAllProstoriiDTO();

        Prostorija GetDetailsForProstorija(Guid id);
        Guid GetProstorijaByName(string name);
        Prostorija GetDetailsForProstorijaByName(string name);

        void CreateNewProstorija(Prostorija p);
        void UpdateProstorija(Prostorija p);
        void DeleteProstorija(Guid id);
    }
}
