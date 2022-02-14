using ExamManager.Domain.DomainModel;
using ExamManager.Domain.DTO;
using ExamManager.Repository.Interface;
using ExamManager.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamManager.Service.Implementation
{
    public class StudentPolagaPredmetService : IStudentPolagaPredmetService
    {
        private readonly IStudentPolagaPredmetRepository studentPolagaPredmetRepository;

        public StudentPolagaPredmetService(IStudentPolagaPredmetRepository studentPolagaPredmetRepository)
        {
            this.studentPolagaPredmetRepository = studentPolagaPredmetRepository;
        }

        public List<StudentPredmetDTO> GetAll()
        {
            return studentPolagaPredmetRepository.GetAll().Select(z => new StudentPredmetDTO { BrojNaIndeks = z.BrojNaIndeks, KodNaPredmet = z.KodNaPredmet }).ToList();
        }

        public List<StudentPolagaPredmet> GetAllPredmetiForStudent(int id)
        {
            return this.studentPolagaPredmetRepository.GetAllPredmetiForStudent(id).ToList();
        }
    }
}
