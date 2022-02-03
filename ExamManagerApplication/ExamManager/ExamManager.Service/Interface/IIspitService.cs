using ExamManager.Domain.DomainModel;
using ExamManager.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Service.Interface
{
    public interface IIspitService
    {
        List<Ispit> GetAllIspiti();
        List<IspitDTO> GetlAllIspitDto();
        List<TerminDTO> GetAllTerminiZaIspiti();
        Ispit GetDetailsForIspit(Guid? id);
        void CreateNewIspit(Ispit i);
        void UpdateIspit(Ispit i);
        void DeleteIspit(Guid? id);
    }
}
