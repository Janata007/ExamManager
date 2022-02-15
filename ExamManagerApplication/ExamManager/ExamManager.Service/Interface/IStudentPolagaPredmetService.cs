using ExamManager.Domain.DomainModel;
using ExamManager.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Service.Interface
{
    public interface IStudentPolagaPredmetService
    {
        List<StudentPredmetDTO> GetAll();
        List<StudentPolagaPredmet> GetAllPredmetiForStudent(int id);
        void Insert(StudentPolagaPredmet studentPolagaPredmet);
    }
}
