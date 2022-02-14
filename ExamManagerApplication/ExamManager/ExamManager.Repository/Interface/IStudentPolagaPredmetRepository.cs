using ExamManager.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.Repository.Interface
{
    public interface IStudentPolagaPredmetRepository
    {
        IEnumerable<StudentPolagaPredmet> GetAll();
        IEnumerable<StudentPolagaPredmet> GetAllPredmetiForStudent(int id);
    }
}
