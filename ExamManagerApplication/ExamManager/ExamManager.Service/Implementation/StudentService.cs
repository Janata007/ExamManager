using ExamManager.Domain.DomainModel;
using ExamManager.Repository.Interface;
using ExamManager.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamManager.Service.Implementation
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository) {

            this._studentRepository = studentRepository;
        
        }

        public void CreateNewStudent(Student s)
        {
            this._studentRepository.Insert(s);
        }

        public void DeleteStudent(int? id)
        {
            var s = this.GetDetailsForStudent(id);
            this._studentRepository.Delete(s);
        }

        public List<Student> Getstudents()
        {
          return  this._studentRepository.GetAll().ToList();
        }

        public Student GetDetailsForStudent(int? id)
        {
            return this._studentRepository.Get(id);
        }

        public void UpdateStudent(Student s)
        {
            this._studentRepository.Update(s);
        }
    }
}
