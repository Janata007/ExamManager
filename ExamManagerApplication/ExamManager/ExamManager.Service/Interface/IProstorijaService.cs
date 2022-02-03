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

        void CreateNewProstorija(Prostorija p);
        void UpdateProstorija(Prostorija p);
        void DeleteProstorija(Guid id);
    }
}
